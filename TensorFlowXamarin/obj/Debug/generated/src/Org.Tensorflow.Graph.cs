using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']"
	[global::Android.Runtime.Register ("org/tensorflow/Graph", DoNotGenerateAcw=true)]
	public sealed partial class Graph : global::Java.Lang.Object, global::Java.Lang.IAutoCloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph.Reference']"
		[global::Android.Runtime.Register ("org/tensorflow/Graph$Reference", DoNotGenerateAcw=true)]
		public partial class Reference : global::Java.Lang.Object, global::Java.Lang.IAutoCloseable {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Graph$Reference", typeof (Reference));
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

			protected Reference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Org.Tensorflow.Graph.Reference __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Graph.Reference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph.Reference']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_nativeHandle;
#pragma warning disable 0169
			static Delegate GetNativeHandleHandler ()
			{
				if (cb_nativeHandle == null)
					cb_nativeHandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NativeHandle);
				return cb_nativeHandle;
			}

			static long n_NativeHandle (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Tensorflow.Graph.Reference __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Graph.Reference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NativeHandle ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph.Reference']/method[@name='nativeHandle' and count(parameter)=0]"
			[Register ("nativeHandle", "()J", "GetNativeHandleHandler")]
			public virtual unsafe long NativeHandle ()
			{
				const string __id = "nativeHandle.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Graph", typeof (Graph));
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

		internal Graph (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/constructor[@name='Graph' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Graph ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='importGraphDef' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("importGraphDef", "([B)V", "")]
		public unsafe void ImportGraphDef (byte[] p0)
		{
			const string __id = "importGraphDef.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='importGraphDef' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("importGraphDef", "([BLjava/lang/String;)V", "")]
		public unsafe void ImportGraphDef (byte[] p0, string p1)
		{
			const string __id = "importGraphDef.([BLjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='opBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("opBuilder", "(Ljava/lang/String;Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;", "")]
		public unsafe global::Org.Tensorflow.OperationBuilder OpBuilder (string p0, string p1)
		{
			const string __id = "opBuilder.(Ljava/lang/String;Ljava/lang/String;)Lorg/tensorflow/OperationBuilder;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='operation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("operation", "(Ljava/lang/String;)Lorg/tensorflow/Operation;", "")]
		public unsafe global::Org.Tensorflow.Operation Operation (string p0)
		{
			const string __id = "operation.(Ljava/lang/String;)Lorg/tensorflow/Operation;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='operations' and count(parameter)=0]"
		[Register ("operations", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Operations ()
		{
			const string __id = "operations.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Graph']/method[@name='toGraphDef' and count(parameter)=0]"
		[Register ("toGraphDef", "()[B", "")]
		public unsafe byte[] ToGraphDef ()
		{
			const string __id = "toGraphDef.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
