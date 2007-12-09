
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
public class ColorKeyFrameTest
{
	[Test]
	public void Properties ()
	{
		Assert.AreEqual ("KeyTime", ColorKeyFrame.KeyTimeProperty.Name, "1");
		Assert.AreEqual (typeof (ColorKeyFrame), ColorKeyFrame.KeyTimeProperty.OwnerType, "2");
		Assert.AreEqual (typeof (KeyTime), ColorKeyFrame.KeyTimeProperty.PropertyType, "3");

		Assert.AreEqual ("Value", ColorKeyFrame.ValueProperty.Name, "4");
		Assert.AreEqual (typeof (ColorKeyFrame), ColorKeyFrame.ValueProperty.OwnerType, "5");
		Assert.AreEqual (typeof (Color), ColorKeyFrame.ValueProperty.PropertyType, "6");
	}
}


}
