using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='TensorFlow']"
	[global::Android.Runtime.Register ("org/tensorflow/TensorFlow", DoNotGenerateAcw=true)]
	public sealed partial class TensorFlow : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/TensorFlow", typeof (TensorFlow));
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

		internal TensorFlow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='TensorFlow']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] LoadLibrary (string p0)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='TensorFlow']/method[@name='registeredOpList' and count(parameter)=0]"
		[Register ("registeredOpList", "()[B", "")]
		public static unsafe byte[] RegisteredOpList ()
		{
			const string __id = "registeredOpList.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='TensorFlow']/method[@name='version' and count(parameter)=0]"
		[Register ("version", "()Ljava/lang/String;", "")]
		public static unsafe string Version ()
		{
			const string __id = "version.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
