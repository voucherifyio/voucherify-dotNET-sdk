#if TRUE && (VOUCHERIFYSERVER || VOUCHERIFYCLIENT)
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if VOUCHERIFYCLIENT
[assembly: AssemblyTitle("Voucherify.Client")]
#else
[assembly: AssemblyTitle("Voucherify")]
#endif
[assembly: AssemblyDescription(".Net SDK for Voucherify - coupons, vouchers, promo codes http://www.voucherify.io")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Rspective")]
[assembly: AssemblyProduct("Voucherify")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("5.0.0.0")]
[assembly: AssemblyFileVersion("5.0.0.0")]
#endif
