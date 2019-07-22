using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']"
	[global::Android.Runtime.Register ("org/tensorflow/Tensor", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Tensor : global::Java.Lang.Object, global::Java.Lang.IAutoCloseable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Tensor", typeof (Tensor));
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

		internal Tensor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='booleanValue' and count(parameter)=0]"
		[Register ("booleanValue", "()Z", "")]
		public unsafe bool BooleanValue ()
		{
			const string __id = "booleanValue.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='bytesValue' and count(parameter)=0]"
		[Register ("bytesValue", "()[B", "")]
		public unsafe byte[] BytesValue ()
		{
			const string __id = "bytesValue.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='U']]"
		[Register ("copyTo", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Java.Lang.Object CopyTo (global::Java.Lang.Object p0)
		{
			const string __id = "copyTo.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='long[]'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("create", "(Ljava/lang/Class;[JLjava/nio/ByteBuffer;)Lorg/tensorflow/Tensor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Tensorflow.Tensor Create (global::Java.Lang.Class p0, long[] p1, global::Java.Nio.ByteBuffer p2)
		{
			const string __id = "create.(Ljava/lang/Class;[JLjava/nio/ByteBuffer;)Lorg/tensorflow/Tensor;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("create", "(Ljava/lang/Object;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (global::Java.Lang.Object p0)
		{
			const string __id = "create.(Ljava/lang/Object;)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("create", "(Ljava/lang/Object;Ljava/lang/Class;)Lorg/tensorflow/Tensor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Tensorflow.Tensor Create (global::Java.Lang.Object p0, global::Java.Lang.Class p1)
		{
			const string __id = "create.(Ljava/lang/Object;Ljava/lang/Class;)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='java.nio.DoubleBuffer']]"
		[Register ("create", "([JLjava/nio/DoubleBuffer;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[] p0, global::Java.Nio.DoubleBuffer p1)
		{
			const string __id = "create.([JLjava/nio/DoubleBuffer;)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='java.nio.FloatBuffer']]"
		[Register ("create", "([JLjava/nio/FloatBuffer;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[] p0, global::Java.Nio.FloatBuffer p1)
		{
			const string __id = "create.([JLjava/nio/FloatBuffer;)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='java.nio.IntBuffer']]"
		[Register ("create", "([JLjava/nio/IntBuffer;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[] p0, global::Java.Nio.IntBuffer p1)
		{
			const string __id = "create.([JLjava/nio/IntBuffer;)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='create' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='java.nio.LongBuffer']]"
		[Register ("create", "([JLjava/nio/LongBuffer;)Lorg/tensorflow/Tensor;", "")]
		public static unsafe global::Org.Tensorflow.Tensor Create (long[] p0, global::Java.Nio.LongBuffer p1)
		{
			const string __id = "create.([JLjava/nio/LongBuffer;)Lorg/tensorflow/Tensor;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='dataType' and count(parameter)=0]"
		[Register ("dataType", "()Lorg/tensorflow/DataType;", "")]
		public unsafe global::Org.Tensorflow.DataType DataType ()
		{
			const string __id = "dataType.()Lorg/tensorflow/DataType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.DataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "")]
		public unsafe double DoubleValue ()
		{
			const string __id = "doubleValue.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='expect' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;U&gt;']]"
		[Register ("expect", "(Ljava/lang/Class;)Lorg/tensorflow/Tensor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Org.Tensorflow.Tensor Expect (global::Java.Lang.Class p0)
		{
			const string __id = "expect.(Ljava/lang/Class;)Lorg/tensorflow/Tensor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Tensor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "")]
		public unsafe float FloatValue ()
		{
			const string __id = "floatValue.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "")]
		public unsafe int IntValue ()
		{
			const string __id = "intValue.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public unsafe long LongValue ()
		{
			const string __id = "longValue.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='numBytes' and count(parameter)=0]"
		[Register ("numBytes", "()I", "")]
		public unsafe int NumBytes ()
		{
			const string __id = "numBytes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='numDimensions' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='numElements' and count(parameter)=0]"
		[Register ("numElements", "()I", "")]
		public unsafe int NumElements ()
		{
			const string __id = "numElements.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='shape' and count(parameter)=0]"
		[Register ("shape", "()[J", "")]
		public unsafe long[] Shape ()
		{
			const string __id = "shape.()[J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("writeTo", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe void WriteTo (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "writeTo.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.nio.DoubleBuffer']]"
		[Register ("writeTo", "(Ljava/nio/DoubleBuffer;)V", "")]
		public unsafe void WriteTo (global::Java.Nio.DoubleBuffer p0)
		{
			const string __id = "writeTo.(Ljava/nio/DoubleBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer']]"
		[Register ("writeTo", "(Ljava/nio/FloatBuffer;)V", "")]
		public unsafe void WriteTo (global::Java.Nio.FloatBuffer p0)
		{
			const string __id = "writeTo.(Ljava/nio/FloatBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.nio.IntBuffer']]"
		[Register ("writeTo", "(Ljava/nio/IntBuffer;)V", "")]
		public unsafe void WriteTo (global::Java.Nio.IntBuffer p0)
		{
			const string __id = "writeTo.(Ljava/nio/IntBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Tensor']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.nio.LongBuffer']]"
		[Register ("writeTo", "(Ljava/nio/LongBuffer;)V", "")]
		public unsafe void WriteTo (global::Java.Nio.LongBuffer p0)
		{
			const string __id = "writeTo.(Ljava/nio/LongBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
