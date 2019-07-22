using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='SavedModelBundle']"
	[global::Android.Runtime.Register ("org/tensorflow/SavedModelBundle", DoNotGenerateAcw=true)]
	public partial class SavedModelBundle : global::Java.Lang.Object, global::Java.Lang.IAutoCloseable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/SavedModelBundle", typeof (SavedModelBundle));
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

		protected SavedModelBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Tensorflow.SavedModelBundle __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.SavedModelBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='SavedModelBundle']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Org.Tensorflow.SavedModelBundle __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.SavedModelBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Graph ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='SavedModelBundle']/method[@name='graph' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='SavedModelBundle']/method[@name='load' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("load", "(Ljava/lang/String;[Ljava/lang/String;)Lorg/tensorflow/SavedModelBundle;", "")]
		public static unsafe global::Org.Tensorflow.SavedModelBundle Load (string p0, params string[] p1)
		{
			const string __id = "load.(Ljava/lang/String;[Ljava/lang/String;)Lorg/tensorflow/SavedModelBundle;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.SavedModelBundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_metaGraphDef;
#pragma warning disable 0169
		static Delegate GetMetaGraphDefHandler ()
		{
			if (cb_metaGraphDef == null)
				cb_metaGraphDef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MetaGraphDef);
			return cb_metaGraphDef;
		}

		static IntPtr n_MetaGraphDef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.SavedModelBundle __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.SavedModelBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.MetaGraphDef ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='SavedModelBundle']/method[@name='metaGraphDef' and count(parameter)=0]"
		[Register ("metaGraphDef", "()[B", "GetMetaGraphDefHandler")]
		public virtual unsafe byte[] MetaGraphDef ()
		{
			const string __id = "metaGraphDef.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_session;
#pragma warning disable 0169
		static Delegate GetSessionHandler ()
		{
			if (cb_session == null)
				cb_session = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Session);
			return cb_session;
		}

		static IntPtr n_Session (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.SavedModelBundle __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.SavedModelBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='SavedModelBundle']/method[@name='session' and count(parameter)=0]"
		[Register ("session", "()Lorg/tensorflow/Session;", "GetSessionHandler")]
		public virtual unsafe global::Org.Tensorflow.Session Session ()
		{
			const string __id = "session.()Lorg/tensorflow/Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
