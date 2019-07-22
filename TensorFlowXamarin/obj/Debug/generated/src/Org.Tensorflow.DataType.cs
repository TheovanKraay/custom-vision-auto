using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']"
	[global::Android.Runtime.Register ("org/tensorflow/DataType", DoNotGenerateAcw=true)]
	public sealed partial class DataType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='BOOL']"
		[Register ("BOOL")]
		public static global::Org.Tensorflow.DataType Bool {
			get {
				const string __id = "BOOL.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='DOUBLE']"
		[Register ("DOUBLE")]
		public static global::Org.Tensorflow.DataType Double {
			get {
				const string __id = "DOUBLE.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='FLOAT']"
		[Register ("FLOAT")]
		public static global::Org.Tensorflow.DataType Float {
			get {
				const string __id = "FLOAT.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='INT32']"
		[Register ("INT32")]
		public static global::Org.Tensorflow.DataType Int32 {
			get {
				const string __id = "INT32.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='INT64']"
		[Register ("INT64")]
		public static global::Org.Tensorflow.DataType Int64 {
			get {
				const string __id = "INT64.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='STRING']"
		[Register ("STRING")]
		public static global::Org.Tensorflow.DataType String {
			get {
				const string __id = "STRING.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/field[@name='UINT8']"
		[Register ("UINT8")]
		public static global::Org.Tensorflow.DataType Uint8 {
			get {
				const string __id = "UINT8.Lorg/tensorflow/DataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/DataType", typeof (DataType));
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

		internal DataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/method[@name='fromClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("fromClass", "(Ljava/lang/Class;)Lorg/tensorflow/DataType;", "")]
		public static unsafe global::Org.Tensorflow.DataType FromClass (global::Java.Lang.Class p0)
		{
			const string __id = "fromClass.(Ljava/lang/Class;)Lorg/tensorflow/DataType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/tensorflow/DataType;", "")]
		public static unsafe global::Org.Tensorflow.DataType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/tensorflow/DataType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='DataType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/tensorflow/DataType;", "")]
		public static unsafe global::Org.Tensorflow.DataType[] Values ()
		{
			const string __id = "values.()[Lorg/tensorflow/DataType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Tensorflow.DataType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Tensorflow.DataType));
			} finally {
			}
		}

	}
}
