
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
public class DoubleAnimationTest
{
	[Test]
	public void Properties ()
	{
		Assert.AreEqual ("By", DoubleAnimation.ByProperty.Name, "1");
		Assert.AreEqual (typeof (DoubleAnimation), DoubleAnimation.ByProperty.OwnerType, "2");
		Assert.AreEqual (typeof (double?), DoubleAnimation.ByProperty.PropertyType, "3");

		Assert.AreEqual ("From", DoubleAnimation.FromProperty.Name, "4");
		Assert.AreEqual (typeof (DoubleAnimation), DoubleAnimation.FromProperty.OwnerType, "5");
		Assert.AreEqual (typeof (double?), DoubleAnimation.FromProperty.PropertyType, "6");

		Assert.AreEqual ("To", DoubleAnimation.ToProperty.Name, "7");
		Assert.AreEqual (typeof (DoubleAnimation), DoubleAnimation.ToProperty.OwnerType, "8");
		Assert.AreEqual (typeof (double?), DoubleAnimation.ToProperty.PropertyType, "9");
	}
}


}
