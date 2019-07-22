using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomVisionCompanion.Services
{
    public interface IMediaService
    {
        Task<List<MediaFile>> TakePhotoAsync();

        Task<List<MediaFile>> PickPhotoAsync();
    }
}
