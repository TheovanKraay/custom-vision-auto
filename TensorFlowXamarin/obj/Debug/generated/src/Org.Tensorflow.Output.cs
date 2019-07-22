using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']"
	[global::Android.Runtime.Register ("org/tensorflow/Output", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Output : global::Java.Lang.Object, global::Org.Tensorflow.IOperand {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/Output", typeof (Output));
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

		internal Output (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']/constructor[@name='Output' and count(parameter)=2 and parameter[1][@type='org.tensorflow.Operation'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/tensorflow/Operation;I)V", "")]
		public unsafe Output (global::Org.Tensorflow.Operation p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/tensorflow/Operation;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']/method[@name='asOutput' and count(parameter)=0]"
		[Register ("asOutput", "()Lorg/tensorflow/Output;", "")]
		public unsafe global::Org.Tensorflow.Output AsOutput ()
		{
			const string __id = "asOutput.()Lorg/tensorflow/Output;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Output> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']/method[@name='dataType' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']/method[@name='index' and count(parameter)=0]"
		[Register ("index", "()I", "")]
		public unsafe int Index ()
		{
			const string __id = "index.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']/method[@name='op' and count(parameter)=0]"
		[Register ("op", "()Lorg/tensorflow/Operation;", "")]
		public unsafe global::Org.Tensorflow.Operation Op ()
		{
			const string __id = "op.()Lorg/tensorflow/Operation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/class[@name='Output']/method[@name='shape' and count(parameter)=0]"
		[Register ("shape", "()Lorg/tensorflow/Shape;", "")]
		public unsafe global::Org.Tensorflow.Shape Shape ()
		{
			const string __id = "shape.()Lorg/tensorflow/Shape;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Shape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
