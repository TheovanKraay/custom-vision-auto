using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.tensorflow']/interface[@name='Operand']"
	[Register ("org/tensorflow/Operand", "", "Org.Tensorflow.IOperandInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IOperand : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow']/interface[@name='Operand']/method[@name='asOutput' and count(parameter)=0]"
		[Register ("asOutput", "()Lorg/tensorflow/Output;", "GetAsOutputHandler:Org.Tensorflow.IOperandInvoker, TensorFlowXamarin")]
		global::Org.Tensorflow.Output AsOutput ();

	}

	[global::Android.Runtime.Register ("org/tensorflow/Operand", DoNotGenerateAcw=true)]
	internal class IOperandInvoker : global::Java.Lang.Object, IOperand {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/tensorflow/Operand", typeof (IOperandInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOperand GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOperand> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.tensorflow.Operand"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOperandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asOutput;
#pragma warning disable 0169
		static Delegate GetAsOutputHandler ()
		{
			if (cb_asOutput == null)
				cb_asOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsOutput);
			return cb_asOutput;
		}

		static IntPtr n_AsOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Tensorflow.IOperand __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.IOperand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsOutput ());
		}
#pragma warning restore 0169

		IntPtr id_asOutput;
		public unsafe global::Org.Tensorflow.Output AsOutput ()
		{
			if (id_asOutput == IntPtr.Zero)
				id_asOutput = JNIEnv.GetMethodID (class_ref, "asOutput", "()Lorg/tensorflow/Output;");
			return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Output> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asOutput), JniHandleOwnership.TransferLocalRef);
		}

	}

}
