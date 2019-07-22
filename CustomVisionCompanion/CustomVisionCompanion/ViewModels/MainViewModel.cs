using CustomVisionCompanion.Common;
using CustomVisionCompanion.Services;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.CustomVisionEngine;
using Plugin.CustomVisionEngine.Models;
using GalaSoft.MvvmLight.Command;
using System.Threading;

namespace CustomVisionCompanion.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IMediaService mediaService;

        private IEnumerable<string> predictions;
        private IEnumerable<string> predictions2;

        public IEnumerable<string> Predictions
        {
            get => predictions;
            set => Set(ref predictions, value);
        }

        public IEnumerable<string> Predictions2
        {
            get => predictions2;
            set => Set(ref predictions2, value);
        }

        private bool isOffline;
        public bool IsOffline
        {
            get => isOffline;
            set => Set(ref isOffline, value);
        }

        private string imagePath;
        public string ImagePath
        {
            get => imagePath;
            set => Set(ref imagePath, value);
        }

        public AutoRelayCommand TakePhotoCommand { get; private set; }

        public AutoRelayCommand PickPhotoCommand { get; private set; }

        public AutoRelayCommand SettingsCommand { get; private set; }

        public MainViewModel(IMediaService mediaService)
        {
            this.mediaService = mediaService;

            CreateCommands();
        }

        private void CreateCommands()
        {
            TakePhotoCommand = new AutoRelayCommand(async () => await AnalyzePhotoAsync(() => mediaService.TakePhotoAsync()));            
            PickPhotoCommand = new AutoRelayCommand(async () => await AnalyzePhotoAsync(() => mediaService.PickPhotoAsync()));
            SettingsCommand = new AutoRelayCommand(() => NavigationService.NavigateTo(Constants.SettingsPage));
        }

        private async Task AnalyzePhotoAsync(Func<Task<List<MediaFile>>> action)
        {
            IsBusy = true;

            try
            {
                IEnumerable<Recognition> predictionsRecognized = null;
                var file = await action.Invoke();
                if (file[0] != null)
                {
                    // Clean up previous results.
                    
                    ImagePath = file[0].Path;

                    // Check whether to use the online or offline version of the prediction model.
                    
                    if (isOffline)
                    {
                        var classifier = CrossOfflineClassifier.Current;
                        predictionsRecognized = await classifier.RecognizeAsync(file[0].GetStream(), file[0].Path);
                    }
                    else
                    {
                        var classifier = CrossOnlineClassifier.Current;
                        predictionsRecognized = await classifier.RecognizeAsync(SettingsService.PredictionKey, Guid.Parse(SettingsService.ProjectId), file[0].GetStream(), null);
                    }

                    Predictions = predictionsRecognized.Select(p => $"{p.Tag}: {p.Probability:P1}");

                    //file[0].Dispose();

                }
                Thread.Sleep(2000);
                if (file[1] != null)
                {
   
                    ImagePath = file[1].Path;

                    // Check whether to use the online or offline version of the prediction model.
                    if (isOffline)
                    {
                        var classifier = CrossOfflineClassifier.Current;
                        predictionsRecognized = await classifier.RecognizeAsync(file[1].GetStream(), file[1].Path);
                    }
                    else
                    {
                        var classifier = CrossOnlineClassifier.Current;
                        predictionsRecognized = await classifier.RecognizeAsync(SettingsService.PredictionKey, Guid.Parse(SettingsService.ProjectId), file[1].GetStream(), null);
                    }

                    Predictions2 = predictionsRecognized.Select(p => $"{p.Tag}: {p.Probability:P1}");
                    //file[1].Dispose();
                }
            }
            catch (Exception ex)
            {
                await DialogService.AlertAsync(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
