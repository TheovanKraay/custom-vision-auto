using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']"
	[global::Android.Runtime.Register ("org/tensorflow/Tensors", DoNotGenerateAcw=true)]
	public sealed partial class Tensors : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Tensors", typeof (Tensors));
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

		internal Tensors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("create", "(Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool p0)
		{
			const string __id = "create.(Z)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("create", "([Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool[] p0)
		{
			const string __id = "create.([Z)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean[][]']]"
		[Register ("create", "([[Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool[][] p0)
		{
			const string __id = "create.([[Z)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean[][][]']]"
		[Register ("create", "([[[Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool[][][] p0)
		{
			const string __id = "create.([[[Z)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean[][][][]']]"
		[Register ("create", "([[[[Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool[][][][] p0)
		{
			const string __id = "create.([[[[Z)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean[][][][][]']]"
		[Register ("create", "([[[[[Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool[][][][][] p0)
		{
			const string __id = "create.([[[[[Z)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean[][][][][][]']]"
		[Register ("create", "([[[[[[Z)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (bool[][][][][][] p0)
		{
			const string __id = "create.([[[[[[Z)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("create", "([B)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (byte[] p0)
		{
			const string __id = "create.([B)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='byte[][]']]"
		[Register ("create", "([[B)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (byte[][] p0)
		{
			const string __id = "create.([[B)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='byte[][][]']]"
		[Register ("create", "([[[B)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (byte[][][] p0)
		{
			const string __id = "create.([[[B)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='byte[][][][]']]"
		[Register ("create", "([[[[B)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (byte[][][][] p0)
		{
			const string __id = "create.([[[[B)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='byte[][][][][]']]"
		[Register ("create", "([[[[[B)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (byte[][][][][] p0)
		{
			const string __id = "create.([[[[[B)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='byte[][][][][][]']]"
		[Register ("create", "([[[[[[B)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (byte[][][][][][] p0)
		{
			const string __id = "create.([[[[[[B)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("create", "(D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double p0)
		{
			const string __id = "create.(D)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("create", "([D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double[] p0)
		{
			const string __id = "create.([D)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double[][]']]"
		[Register ("create", "([[D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double[][] p0)
		{
			const string __id = "create.([[D)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double[][][]']]"
		[Register ("create", "([[[D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double[][][] p0)
		{
			const string __id = "create.([[[D)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double[][][][]']]"
		[Register ("create", "([[[[D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double[][][][] p0)
		{
			const string __id = "create.([[[[D)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double[][][][][]']]"
		[Register ("create", "([[[[[D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double[][][][][] p0)
		{
			const string __id = "create.([[[[[D)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='double[][][][][][]']]"
		[Register ("create", "([[[[[[D)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (double[][][][][][] p0)
		{
			const string __id = "create.([[[[[[D)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("create", "(F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float p0)
		{
			const string __id = "create.(F)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("create", "([F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float[] p0)
		{
			const string __id = "create.([F)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float[][]']]"
		[Register ("create", "([[F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float[][] p0)
		{
			const string __id = "create.([[F)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float[][][]']]"
		[Register ("create", "([[[F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float[][][] p0)
		{
			const string __id = "create.([[[F)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float[][][][]']]"
		[Register ("create", "([[[[F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float[][][][] p0)
		{
			const string __id = "create.([[[[F)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float[][][][][]']]"
		[Register ("create", "([[[[[F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float[][][][][] p0)
		{
			const string __id = "create.([[[[[F)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float[][][][][][]']]"
		[Register ("create", "([[[[[[F)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (float[][][][][][] p0)
		{
			const string __id = "create.([[[[[[F)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int p0)
		{
			const string __id = "create.(I)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("create", "([I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int[] p0)
		{
			const string __id = "create.([I)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int[][]']]"
		[Register ("create", "([[I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int[][] p0)
		{
			const string __id = "create.([[I)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int[][][]']]"
		[Register ("create", "([[[I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int[][][] p0)
		{
			const string __id = "create.([[[I)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int[][][][]']]"
		[Register ("create", "([[[[I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int[][][][] p0)
		{
			const string __id = "create.([[[[I)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int[][][][][]']]"
		[Register ("create", "([[[[[I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int[][][][][] p0)
		{
			const string __id = "create.([[[[[I)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int[][][][][][]']]"
		[Register ("create", "([[[[[[I)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (int[][][][][][] p0)
		{
			const string __id = "create.([[[[[[I)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (string p0)
		{
			const string __id = "create.(Ljava/lang/String;)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("create", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (string p0, global::Java.Nio.Charset.Charset p1)
		{
			const string __id = "create.(Ljava/lang/String;Ljava/nio/charset/Charset;)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("create", "(J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long p0)
		{
			const string __id = "create.(J)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("create", "([J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[] p0)
		{
			const string __id = "create.([J)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long[][]']]"
		[Register ("create", "([[J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[][] p0)
		{
			const string __id = "create.([[J)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long[][][]']]"
		[Register ("create", "([[[J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[][][] p0)
		{
			const string __id = "create.([[[J)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long[][][][]']]"
		[Register ("create", "([[[[J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[][][][] p0)
		{
			const string __id = "create.([[[[J)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long[][][][][]']]"
		[Register ("create", "([[[[[J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[][][][][] p0)
		{
			const string __id = "create.([[[[[J)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensors']/method[@name='create' and count(parameter)=1 and parameter[1][@type='long[][][][][][]']]"
		[Register ("create", "([[[[[[J)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[][][][][][] p0)
		{
			const string __id = "create.([[[[[[J)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
