
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
public class MatrixKeyFrameTest
{
	[Test]
	public void Properties ()
	{
		Assert.AreEqual ("KeyTime", MatrixKeyFrame.KeyTimeProperty.Name, "1");
		Assert.AreEqual (typeof (MatrixKeyFrame), MatrixKeyFrame.KeyTimeProperty.OwnerType, "2");
		Assert.AreEqual (typeof (KeyTime), MatrixKeyFrame.KeyTimeProperty.PropertyType, "3");

		Assert.AreEqual ("Value", MatrixKeyFrame.ValueProperty.Name, "4");
		Assert.AreEqual (typeof (MatrixKeyFrame), MatrixKeyFrame.ValueProperty.OwnerType, "5");
		Assert.AreEqual (typeof (Matrix), MatrixKeyFrame.ValueProperty.PropertyType, "6");
	}
}


}
