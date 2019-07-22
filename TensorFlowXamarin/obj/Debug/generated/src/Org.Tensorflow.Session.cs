using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Session']"
	[global::Android.Runtime.Register ("org/tensorflow/Session", DoNotGenerateAcw=true)]
	public sealed partial class Session : global::Java.Lang.Object, global::Java.Lang.IAutoCloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Run']"
		[global::Android.Runtime.Register ("org/tensorflow/Session$Run", DoNotGenerateAcw=true)]
		public sealed partial class Run : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Run']/field[@name='metadata']"
			[Register ("metadata")]
			public IList<byte> Metadata {
				get {
					const string __id = "metadata.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "metadata.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Run']/field[@name='outputs']"
			[Register ("outputs")]
			public global::System.Collections.IList Outputs {
				get {
					const string __id = "outputs.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "outputs.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Session$Run", typeof (Run));
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

			internal Run (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Run']/constructor[@name='Session.Run' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Run ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']"
		[global::Android.Runtime.Register ("org/tensorflow/Session$Runner", DoNotGenerateAcw=true)]
		public sealed partial class Runner : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Session$Runner", typeof (Runner));
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

			internal Runner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/constructor[@name='Session.Runner' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Session']]"
			[Register (".ctor", "(Lorg/tensorflow/Session;)V", "")]
			public unsafe Runner (global::Org.Tensorflow.Session __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='addTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addTarget", "(Ljava/lang/String;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner AddTarget (string p0)
			{
				const string __id = "addTarget.(Ljava/lang/String;)Lorg/tensorflow/Session$Runner;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='addTarget' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Operation']]"
			[Register ("addTarget", "(Lorg/tensorflow/Operation;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner AddTarget (global::Org.Tensorflow.Operation p0)
			{
				const string __id = "addTarget.(Lorg/tensorflow/Operation;)Lorg/tensorflow/Session$Runner;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='feed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.tensorflow.Tensor&lt;?&gt;']]"
			[Register ("feed", "(Ljava/lang/String;ILorg/tensorflow/Tensor;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner Feed (string p0, int p1, global::Org.Tensorflow.Tensor p2)
			{
				const string __id = "feed.(Ljava/lang/String;ILorg/tensorflow/Tensor;)Lorg/tensorflow/Session$Runner;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='feed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.tensorflow.Tensor&lt;?&gt;']]"
			[Register ("feed", "(Ljava/lang/String;Lorg/tensorflow/Tensor;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner Feed (string p0, global::Org.Tensorflow.Tensor p1)
			{
				const string __id = "feed.(Ljava/lang/String;Lorg/tensorflow/Tensor;)Lorg/tensorflow/Session$Runner;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='feed' and count(parameter)=2 and parameter[1][@type='org.tensorflow.Output&lt;?&gt;'] and parameter[2][@type='org.tensorflow.Tensor&lt;?&gt;']]"
			[Register ("feed", "(Lorg/tensorflow/Output;Lorg/tensorflow/Tensor;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner Feed (global::Org.Tensorflow.Output p0, global::Org.Tensorflow.Tensor p1)
			{
				const string __id = "feed.(Lorg/tensorflow/Output;Lorg/tensorflow/Tensor;)Lorg/tensorflow/Session$Runner;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='fetch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fetch", "(Ljava/lang/String;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner Fetch (string p0)
			{
				const string __id = "fetch.(Ljava/lang/String;)Lorg/tensorflow/Session$Runner;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("fetch", "(Ljava/lang/String;I)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner Fetch (string p0, int p1)
			{
				const string __id = "fetch.(Ljava/lang/String;I)Lorg/tensorflow/Session$Runner;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='fetch' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Output&lt;?&gt;']]"
			[Register ("fetch", "(Lorg/tensorflow/Output;)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner Fetch (global::Org.Tensorflow.Output p0)
			{
				const string __id = "fetch.(Lorg/tensorflow/Output;)Lorg/tensorflow/Session$Runner;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Org.Tensorflow.Tensor> Run ()
			{
				const string __id = "run.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Tensorflow.Tensor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='runAndFetchMetadata' and count(parameter)=0]"
			[Register ("runAndFetchMetadata", "()Lorg/tensorflow/Session$Run;", "")]
			public unsafe global::Org.Tensorflow.Session.Run RunAndFetchMetadata ()
			{
				const string __id = "runAndFetchMetadata.()Lorg/tensorflow/Session$Run;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Run> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session.Runner']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setOptions", "([B)Lorg/tensorflow/Session$Runner;", "")]
			public unsafe global::Org.Tensorflow.Session.Runner SetOptions (byte[] p0)
			{
				const string __id = "setOptions.([B)Lorg/tensorflow/Session$Runner;";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Session", typeof (Session));
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

		internal Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow']/class[@name='Session']/constructor[@name='Session' and count(parameter)=1 and parameter[1][@type='org.tensorflow.Graph']]"
		[Register (".ctor", "(Lorg/tensorflow/Graph;)V", "")]
		public unsafe Session (global::Org.Tensorflow.Graph p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow']/class[@name='Session']/constructor[@name='Session' and count(parameter)=2 and parameter[1][@type='org.tensorflow.Graph'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorg/tensorflow/Graph;[B)V", "")]
		public unsafe Session (global::Org.Tensorflow.Graph p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/tensorflow/Graph;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Session']/method[@name='runner' and count(parameter)=0]"
		[Register ("runner", "()Lorg/tensorflow/Session$Runner;", "")]
		public unsafe global::Org.Tensorflow.Session.Runner InvokeRunner ()
		{
			const string __id = "runner.()Lorg/tensorflow/Session$Runner;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Session.Runner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
