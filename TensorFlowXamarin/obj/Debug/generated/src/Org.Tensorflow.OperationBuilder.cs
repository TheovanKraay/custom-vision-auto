using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']"
	[global::Android.Runtime.Register ("org/tensorflow/OperationBuilder", DoNotGenerateAcw=true)]
	public sealed partial class OperationBuilder : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/OperationBuilder", typeof (OperationBuilder));
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

		internal OperationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='addControlInput' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Operation']]"
		[Register ("addControlInput", "(Lorg/tensorflow/Operation;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder AddControlInput (global::Org.Tensorflow.Operation p0)
		{
			const string __id = "addControlInput.(Lorg/tensorflow/Operation;)Lorg/tensorflow/OperationBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='addInput' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Output&lt;?&gt;']]"
		[Register ("addInput", "(Lorg/tensorflow/Output;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder AddInput (global::Org.Tensorflow.Output p0)
		{
			const string __id = "addInput.(Lorg/tensorflow/Output;)Lorg/tensorflow/OperationBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='addInputList' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Output&lt;?&gt;[]']]"
		[Register ("addInputList", "([Lorg/tensorflow/Output;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder AddInputList (global::Org.Tensorflow.Output[] p0)
		{
			const string __id = "addInputList.([Lorg/tensorflow/Output;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/tensorflow/Operation;", "")]
		public unsafe global::Org.Tensorflow.Operation Build ()
		{
			const string __id = "build.()Lorg/tensorflow/Operation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setAttr", "(Ljava/lang/String;Z)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, bool p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;Z)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[Z)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, bool[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[Z)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[B)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, byte[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[B)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("setAttr", "(Ljava/lang/String;F)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, float p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;F)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[F)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, float[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[F)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAttr", "(Ljava/lang/String;Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, string p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, string[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("setAttr", "(Ljava/lang/String;J)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, long p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;J)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[J)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, long[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[J)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.DataType']]"
		[Register ("setAttr", "(Ljava/lang/String;Lorg/tensorflow/DataType;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, global::Org.Tensorflow.DataType p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;Lorg/tensorflow/DataType;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.DataType[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[Lorg/tensorflow/DataType;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, global::Org.Tensorflow.DataType[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[Lorg/tensorflow/DataType;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.Shape']]"
		[Register ("setAttr", "(Ljava/lang/String;Lorg/tensorflow/Shape;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, global::Org.Tensorflow.Shape p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;Lorg/tensorflow/Shape;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.Shape[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[Lorg/tensorflow/Shape;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, global::Org.Tensorflow.Shape[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[Lorg/tensorflow/Shape;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.Tensor&lt;?&gt;']]"
		[Register ("setAttr", "(Ljava/lang/String;Lorg/tensorflow/Tensor;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, global::Org.Tensorflow.Tensor p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;Lorg/tensorflow/Tensor;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.Tensor&lt;?&gt;[]']]"
		[Register ("setAttr", "(Ljava/lang/String;[Lorg/tensorflow/Tensor;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetAttr (string p0, global::Org.Tensorflow.Tensor[] p1)
		{
			const string __id = "setAttr.(Ljava/lang/String;[Lorg/tensorflow/Tensor;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='OperationBuilder']/method[@name='setDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDevice", "(Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder SetDevice (string p0)
		{
			const string __id = "setDevice.(Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.OperationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
