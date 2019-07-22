using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow.Contrib.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='RunStats']"
	[global::Android.Runtime.Register ("org/tensorflow/contrib/android/RunStats", DoNotGenerateAcw=true)]
	public partial class RunStats : global::Java.Lang.Object, global::Java.Lang.IAutoCloseable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/contrib/android/RunStats", typeof (RunStats));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected RunStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='RunStats']/constructor[@name='RunStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RunStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_add_arrayB;
#pragma warning disable 0169
		static Delegate GetAdd_arrayBHandler ()
		{
			if (cb_add_arrayB == null)
				cb_add_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_arrayB);
			return cb_add_arrayB;
		}

		static void n_Add_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Tensorflow.Contrib.Android.RunStats __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.RunStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Add (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='RunStats']/method[@name='add' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("add", "([B)V", "GetAdd_arrayBHandler")]
		public virtual unsafe void Add (byte[] p0)
		{
			const string __id = "add.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.Contrib.Android.RunStats __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.RunStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='RunStats']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='RunStats']/method[@name='runOptions' and count(parameter)=0]"
		[Register ("runOptions", "()[B", "")]
		public static unsafe byte[] RunOptions ()
		{
			const string __id = "runOptions.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_summary;
#pragma warning disable 0169
		static Delegate GetSummaryHandler ()
		{
			if (cb_summary == null)
				cb_summary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Summary);
			return cb_summary;
		}

		static IntPtr n_Summary (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.Contrib.Android.RunStats __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.RunStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Summary ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='RunStats']/method[@name='summary' and count(parameter)=0]"
		[Register ("summary", "()Ljava/lang/String;", "GetSummaryHandler")]
		public virtual unsafe string Summary ()
		{
			const string __id = "summary.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
