
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using NUnit.Framework;

namespace MonoTests.System.Windows.Media.Animation {


[TestFixture]
public class Int64KeyFrameTest
{
	[Test]
	public void Properties ()
	{
		Assert.AreEqual ("KeyTime", Int64KeyFrame.KeyTimeProperty.Name, "1");
		Assert.AreEqual (typeof (Int64KeyFrame), Int64KeyFrame.KeyTimeProperty.OwnerType, "2");
		Assert.AreEqual (typeof (KeyTime), Int64KeyFrame.KeyTimeProperty.PropertyType, "3");

		Assert.AreEqual ("Value", Int64KeyFrame.ValueProperty.Name, "4");
		Assert.AreEqual (typeof (Int64KeyFrame), Int64KeyFrame.ValueProperty.OwnerType, "5");
		Assert.AreEqual (typeof (long), Int64KeyFrame.ValueProperty.PropertyType, "6");
	}
}


}
