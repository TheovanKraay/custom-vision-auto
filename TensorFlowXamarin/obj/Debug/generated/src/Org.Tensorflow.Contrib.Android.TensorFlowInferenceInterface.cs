using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow.Contrib.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']"
	[global::Android.Runtime.Register ("org/tensorflow/contrib/android/TensorFlowInferenceInterface", DoNotGenerateAcw=true)]
	public partial class TensorFlowInferenceInterface : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/contrib/android/TensorFlowInferenceInterface", typeof (TensorFlowInferenceInterface));
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

		protected TensorFlowInferenceInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/constructor[@name='TensorFlowInferenceInterface' and count(parameter)=2 and parameter[1][@type='android.content.res.AssetManager'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/res/AssetManager;Ljava/lang/String;)V", "")]
		public unsafe TensorFlowInferenceInterface (global::Android.Content.Res.AssetManager p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/AssetManager;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/constructor[@name='TensorFlowInferenceInterface' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe TensorFlowInferenceInterface (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/constructor[@name='TensorFlowInferenceInterface' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Graph']]"
		[Register (".ctor", "(Lorg/tensorflow/Graph;)V", "")]
		public unsafe TensorFlowInferenceInterface (global::Org.Tensorflow.Graph p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/tensorflow/Graph;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getStatString;
#pragma warning disable 0169
		static Delegate GetGetStatStringHandler ()
		{
			if (cb_getStatString == null)
				cb_getStatString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatString);
			return cb_getStatString;
		}

		static IntPtr n_GetStatString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StatString);
		}
#pragma warning restore 0169

		public virtual unsafe string StatString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='getStatString' and count(parameter)=0]"
			[Register ("getStatString", "()Ljava/lang/String;", "GetGetStatStringHandler")]
			get {
				const string __id = "getStatString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_feed_Ljava_lang_String_arrayZarrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_arrayZarrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_arrayZarrayJ == null)
				cb_feed_Ljava_lang_String_arrayZarrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_arrayZarrayJ);
			return cb_feed_Ljava_lang_String_arrayZarrayJ;
		}

		static void n_Feed_Ljava_lang_String_arrayZarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool[] p1 = (bool[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (bool));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean[]'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;[Z[J)V", "GetFeed_Ljava_lang_String_arrayZarrayJHandler")]
		public virtual unsafe void Feed (string p0, bool[] p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;[Z[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_arrayBarrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_arrayBarrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_arrayBarrayJ == null)
				cb_feed_Ljava_lang_String_arrayBarrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_arrayBarrayJ);
			return cb_feed_Ljava_lang_String_arrayBarrayJ;
		}

		static void n_Feed_Ljava_lang_String_arrayBarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;[B[J)V", "GetFeed_Ljava_lang_String_arrayBarrayJHandler")]
		public virtual unsafe void Feed (string p0, byte[] p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;[B[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_arrayDarrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_arrayDarrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_arrayDarrayJ == null)
				cb_feed_Ljava_lang_String_arrayDarrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_arrayDarrayJ);
			return cb_feed_Ljava_lang_String_arrayDarrayJ;
		}

		static void n_Feed_Ljava_lang_String_arrayDarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;[D[J)V", "GetFeed_Ljava_lang_String_arrayDarrayJHandler")]
		public virtual unsafe void Feed (string p0, double[] p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;[D[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_arrayFarrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_arrayFarrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_arrayFarrayJ == null)
				cb_feed_Ljava_lang_String_arrayFarrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_arrayFarrayJ);
			return cb_feed_Ljava_lang_String_arrayFarrayJ;
		}

		static void n_Feed_Ljava_lang_String_arrayFarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;[F[J)V", "GetFeed_Ljava_lang_String_arrayFarrayJHandler")]
		public virtual unsafe void Feed (string p0, float[] p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;[F[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_arrayIarrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_arrayIarrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_arrayIarrayJ == null)
				cb_feed_Ljava_lang_String_arrayIarrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_arrayIarrayJ);
			return cb_feed_Ljava_lang_String_arrayIarrayJ;
		}

		static void n_Feed_Ljava_lang_String_arrayIarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;[I[J)V", "GetFeed_Ljava_lang_String_arrayIarrayJHandler")]
		public virtual unsafe void Feed (string p0, int[] p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;[I[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJ == null)
				cb_feed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJ);
			return cb_feed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJ;
		}

		static void n_Feed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;Ljava/nio/ByteBuffer;[J)V", "GetFeed_Ljava_lang_String_Ljava_nio_ByteBuffer_arrayJHandler")]
		public virtual unsafe void Feed (string p0, global::Java.Nio.ByteBuffer p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;Ljava/nio/ByteBuffer;[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJ == null)
				cb_feed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJ);
			return cb_feed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJ;
		}

		static void n_Feed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.DoubleBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.DoubleBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.DoubleBuffer'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;Ljava/nio/DoubleBuffer;[J)V", "GetFeed_Ljava_lang_String_Ljava_nio_DoubleBuffer_arrayJHandler")]
		public virtual unsafe void Feed (string p0, global::Java.Nio.DoubleBuffer p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;Ljava/nio/DoubleBuffer;[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJ == null)
				cb_feed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJ);
			return cb_feed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJ;
		}

		static void n_Feed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.FloatBuffer'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;Ljava/nio/FloatBuffer;[J)V", "GetFeed_Ljava_lang_String_Ljava_nio_FloatBuffer_arrayJHandler")]
		public virtual unsafe void Feed (string p0, global::Java.Nio.FloatBuffer p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;Ljava/nio/FloatBuffer;[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJ == null)
				cb_feed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJ);
			return cb_feed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJ;
		}

		static void n_Feed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.IntBuffer'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;Ljava/nio/IntBuffer;[J)V", "GetFeed_Ljava_lang_String_Ljava_nio_IntBuffer_arrayJHandler")]
		public virtual unsafe void Feed (string p0, global::Java.Nio.IntBuffer p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;Ljava/nio/IntBuffer;[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJ == null)
				cb_feed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJ);
			return cb_feed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJ;
		}

		static void n_Feed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.LongBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.LongBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.LongBuffer'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;Ljava/nio/LongBuffer;[J)V", "GetFeed_Ljava_lang_String_Ljava_nio_LongBuffer_arrayJHandler")]
		public virtual unsafe void Feed (string p0, global::Java.Nio.LongBuffer p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;Ljava/nio/LongBuffer;[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feed_Ljava_lang_String_arrayJarrayJ;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_String_arrayJarrayJHandler ()
		{
			if (cb_feed_Ljava_lang_String_arrayJarrayJ == null)
				cb_feed_Ljava_lang_String_arrayJarrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_String_arrayJarrayJ);
			return cb_feed_Ljava_lang_String_arrayJarrayJ;
		}

		static void n_Feed_Ljava_lang_String_arrayJarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long[] p1 = (long[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (long));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Feed (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]'] and parameter[3][@type='long...']]"
		[Register ("feed", "(Ljava/lang/String;[J[J)V", "GetFeed_Ljava_lang_String_arrayJarrayJHandler")]
		public virtual unsafe void Feed (string p0, long[] p1, params long[] p2)
		{
			const string __id = "feed.(Ljava/lang/String;[J[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_feedString_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetFeedString_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_feedString_Ljava_lang_String_arrayB == null)
				cb_feedString_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_FeedString_Ljava_lang_String_arrayB);
			return cb_feedString_Ljava_lang_String_arrayB;
		}

		static void n_FeedString_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.FeedString (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feedString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("feedString", "(Ljava/lang/String;[B)V", "GetFeedString_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void FeedString (string p0, byte[] p1)
		{
			const string __id = "feedString.(Ljava/lang/String;[B)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_feedString_Ljava_lang_String_arrayarrayB;
#pragma warning disable 0169
		static Delegate GetFeedString_Ljava_lang_String_arrayarrayBHandler ()
		{
			if (cb_feedString_Ljava_lang_String_arrayarrayB == null)
				cb_feedString_Ljava_lang_String_arrayarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_FeedString_Ljava_lang_String_arrayarrayB);
			return cb_feedString_Ljava_lang_String_arrayarrayB;
		}

		static void n_FeedString_Ljava_lang_String_arrayarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[][] p1 = (byte[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte[]));
			__this.FeedString (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='feedString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[][]']]"
		[Register ("feedString", "(Ljava/lang/String;[[B)V", "GetFeedString_Ljava_lang_String_arrayarrayBHandler")]
		public virtual unsafe void FeedString (string p0, byte[][] p1)
		{
			const string __id = "feedString.(Ljava/lang/String;[[B)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_fetch_Ljava_lang_String_arrayB == null)
				cb_fetch_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_arrayB);
			return cb_fetch_Ljava_lang_String_arrayB;
		}

		static void n_Fetch_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Fetch (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("fetch", "(Ljava/lang/String;[B)V", "GetFetch_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void Fetch (string p0, byte[] p1)
		{
			const string __id = "fetch.(Ljava/lang/String;[B)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_arrayD;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_arrayDHandler ()
		{
			if (cb_fetch_Ljava_lang_String_arrayD == null)
				cb_fetch_Ljava_lang_String_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_arrayD);
			return cb_fetch_Ljava_lang_String_arrayD;
		}

		static void n_Fetch_Ljava_lang_String_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Fetch (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]']]"
		[Register ("fetch", "(Ljava/lang/String;[D)V", "GetFetch_Ljava_lang_String_arrayDHandler")]
		public virtual unsafe void Fetch (string p0, double[] p1)
		{
			const string __id = "fetch.(Ljava/lang/String;[D)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_arrayF;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_arrayFHandler ()
		{
			if (cb_fetch_Ljava_lang_String_arrayF == null)
				cb_fetch_Ljava_lang_String_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_arrayF);
			return cb_fetch_Ljava_lang_String_arrayF;
		}

		static void n_Fetch_Ljava_lang_String_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.Fetch (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float[]']]"
		[Register ("fetch", "(Ljava/lang/String;[F)V", "GetFetch_Ljava_lang_String_arrayFHandler")]
		public virtual unsafe void Fetch (string p0, float[] p1)
		{
			const string __id = "fetch.(Ljava/lang/String;[F)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_arrayIHandler ()
		{
			if (cb_fetch_Ljava_lang_String_arrayI == null)
				cb_fetch_Ljava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_arrayI);
			return cb_fetch_Ljava_lang_String_arrayI;
		}

		static void n_Fetch_Ljava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.Fetch (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]']]"
		[Register ("fetch", "(Ljava/lang/String;[I)V", "GetFetch_Ljava_lang_String_arrayIHandler")]
		public virtual unsafe void Fetch (string p0, int[] p1)
		{
			const string __id = "fetch.(Ljava/lang/String;[I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_fetch_Ljava_lang_String_Ljava_nio_ByteBuffer_ == null)
				cb_fetch_Ljava_lang_String_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_Ljava_nio_ByteBuffer_);
			return cb_fetch_Ljava_lang_String_Ljava_nio_ByteBuffer_;
		}

		static void n_Fetch_Ljava_lang_String_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("fetch", "(Ljava/lang/String;Ljava/nio/ByteBuffer;)V", "GetFetch_Ljava_lang_String_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Fetch (string p0, global::Java.Nio.ByteBuffer p1)
		{
			const string __id = "fetch.(Ljava/lang/String;Ljava/nio/ByteBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_Handler ()
		{
			if (cb_fetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_ == null)
				cb_fetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_);
			return cb_fetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_;
		}

		static void n_Fetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.DoubleBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.DoubleBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.DoubleBuffer']]"
		[Register ("fetch", "(Ljava/lang/String;Ljava/nio/DoubleBuffer;)V", "GetFetch_Ljava_lang_String_Ljava_nio_DoubleBuffer_Handler")]
		public virtual unsafe void Fetch (string p0, global::Java.Nio.DoubleBuffer p1)
		{
			const string __id = "fetch.(Ljava/lang/String;Ljava/nio/DoubleBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_Ljava_nio_FloatBuffer_Handler ()
		{
			if (cb_fetch_Ljava_lang_String_Ljava_nio_FloatBuffer_ == null)
				cb_fetch_Ljava_lang_String_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_Ljava_nio_FloatBuffer_);
			return cb_fetch_Ljava_lang_String_Ljava_nio_FloatBuffer_;
		}

		static void n_Fetch_Ljava_lang_String_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.FloatBuffer']]"
		[Register ("fetch", "(Ljava/lang/String;Ljava/nio/FloatBuffer;)V", "GetFetch_Ljava_lang_String_Ljava_nio_FloatBuffer_Handler")]
		public virtual unsafe void Fetch (string p0, global::Java.Nio.FloatBuffer p1)
		{
			const string __id = "fetch.(Ljava/lang/String;Ljava/nio/FloatBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_Ljava_nio_IntBuffer_;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_Ljava_nio_IntBuffer_Handler ()
		{
			if (cb_fetch_Ljava_lang_String_Ljava_nio_IntBuffer_ == null)
				cb_fetch_Ljava_lang_String_Ljava_nio_IntBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_Ljava_nio_IntBuffer_);
			return cb_fetch_Ljava_lang_String_Ljava_nio_IntBuffer_;
		}

		static void n_Fetch_Ljava_lang_String_Ljava_nio_IntBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.IntBuffer']]"
		[Register ("fetch", "(Ljava/lang/String;Ljava/nio/IntBuffer;)V", "GetFetch_Ljava_lang_String_Ljava_nio_IntBuffer_Handler")]
		public virtual unsafe void Fetch (string p0, global::Java.Nio.IntBuffer p1)
		{
			const string __id = "fetch.(Ljava/lang/String;Ljava/nio/IntBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_Ljava_nio_LongBuffer_;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_Ljava_nio_LongBuffer_Handler ()
		{
			if (cb_fetch_Ljava_lang_String_Ljava_nio_LongBuffer_ == null)
				cb_fetch_Ljava_lang_String_Ljava_nio_LongBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_Ljava_nio_LongBuffer_);
			return cb_fetch_Ljava_lang_String_Ljava_nio_LongBuffer_;
		}

		static void n_Fetch_Ljava_lang_String_Ljava_nio_LongBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.LongBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.LongBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.LongBuffer']]"
		[Register ("fetch", "(Ljava/lang/String;Ljava/nio/LongBuffer;)V", "GetFetch_Ljava_lang_String_Ljava_nio_LongBuffer_Handler")]
		public virtual unsafe void Fetch (string p0, global::Java.Nio.LongBuffer p1)
		{
			const string __id = "fetch.(Ljava/lang/String;Ljava/nio/LongBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetch_Ljava_lang_String_arrayJ;
#pragma warning disable 0169
		static Delegate GetFetch_Ljava_lang_String_arrayJHandler ()
		{
			if (cb_fetch_Ljava_lang_String_arrayJ == null)
				cb_fetch_Ljava_lang_String_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Fetch_Ljava_lang_String_arrayJ);
			return cb_fetch_Ljava_lang_String_arrayJ;
		}

		static void n_Fetch_Ljava_lang_String_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long[] p1 = (long[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.Fetch (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long[]']]"
		[Register ("fetch", "(Ljava/lang/String;[J)V", "GetFetch_Ljava_lang_String_arrayJHandler")]
		public virtual unsafe void Fetch (string p0, long[] p1)
		{
			const string __id = "fetch.(Ljava/lang/String;[J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_graph;
#pragma warning disable 0169
		static Delegate GetGraphHandler ()
		{
			if (cb_graph == null)
				cb_graph = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Graph);
			return cb_graph;
		}

		static IntPtr n_Graph (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Graph ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='graph' and count(parameter)=0]"
		[Register ("graph", "()Lorg/tensorflow/Graph;", "GetGraphHandler")]
		public virtual unsafe global::Org.Tensorflow.Graph Graph ()
		{
			const string __id = "graph.()Lorg/tensorflow/Graph;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Graph> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_graphOperation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGraphOperation_Ljava_lang_String_Handler ()
		{
			if (cb_graphOperation_Ljava_lang_String_ == null)
				cb_graphOperation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GraphOperation_Ljava_lang_String_);
			return cb_graphOperation_Ljava_lang_String_;
		}

		static IntPtr n_GraphOperation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GraphOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='graphOperation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("graphOperation", "(Ljava/lang/String;)Lorg/tensorflow/Operation;", "GetGraphOperation_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Tensorflow.Operation GraphOperation (string p0)
		{
			const string __id = "graphOperation.(Ljava/lang/String;)Lorg/tensorflow/Operation;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_run_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRun_arrayLjava_lang_String_Handler ()
		{
			if (cb_run_arrayLjava_lang_String_ == null)
				cb_run_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_arrayLjava_lang_String_);
			return cb_run_arrayLjava_lang_String_;
		}

		static void n_Run_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Run (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("run", "([Ljava/lang/String;)V", "GetRun_arrayLjava_lang_String_Handler")]
		public virtual unsafe void Run (string[] p0)
		{
			const string __id = "run.([Ljava/lang/String;)V";
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

		static Delegate cb_run_arrayLjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetRun_arrayLjava_lang_String_ZHandler ()
		{
			if (cb_run_arrayLjava_lang_String_Z == null)
				cb_run_arrayLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Run_arrayLjava_lang_String_Z);
			return cb_run_arrayLjava_lang_String_Z;
		}

		static void n_Run_arrayLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Contrib.Android.TensorFlowInferenceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Run (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.contrib.android']/class[@name='TensorFlowInferenceInterface']/method[@name='run' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='boolean']]"
		[Register ("run", "([Ljava/lang/String;Z)V", "GetRun_arrayLjava_lang_String_ZHandler")]
		public virtual unsafe void Run (string[] p0, bool p1)
		{
			const string __id = "run.([Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
