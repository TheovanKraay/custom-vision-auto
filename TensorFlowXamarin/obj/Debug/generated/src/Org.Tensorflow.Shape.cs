using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Shape']"
	[global::Android.Runtime.Register ("org/tensorflow/Shape", DoNotGenerateAcw=true)]
	public sealed partial class Shape : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Shape", typeof (Shape));
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

		internal Shape (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Shape']/method[@name='make' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long...']]"
		[Register ("make", "(J[J)Lorg/tensorflow/Shape;", "")]
		public static unsafe global::Org.Tensorflow.Shape Make (long p0, params long[] p1)
		{
			const string __id = "make.(J[J)Lorg/tensorflow/Shape;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Shape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Shape']/method[@name='numDimensions' and count(parameter)=0]"
		[Register ("numDimensions", "()I", "")]
		public unsafe int NumDimensions ()
		{
			const string __id = "numDimensions.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Shape']/method[@name='scalar' and count(parameter)=0]"
		[Register ("scalar", "()Lorg/tensorflow/Shape;", "")]
		public static unsafe global::Org.Tensorflow.Shape Scalar ()
		{
			const string __id = "scalar.()Lorg/tensorflow/Shape;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Shape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Shape']/method[@name='size' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("size", "(I)J", "")]
		public unsafe long Size (int p0)
		{
			const string __id = "size.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Shape']/method[@name='unknown' and count(parameter)=0]"
		[Register ("unknown", "()Lorg/tensorflow/Shape;", "")]
		public static unsafe global::Org.Tensorflow.Shape Unknown ()
		{
			const string __id = "unknown.()Lorg/tensorflow/Shape;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Shape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
