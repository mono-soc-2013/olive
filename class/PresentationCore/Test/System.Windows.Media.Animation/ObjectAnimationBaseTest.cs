
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
public class ObjectAnimationBaseTest
{
	class ObjectAnimationBasePoker : ObjectAnimationBase
	{
		protected override object GetCurrentValueCore (object defaultOriginValue, object defaultDestinationValue,
							    AnimationClock animationClock)
		{
			throw new NotImplementedException ();
		}

		protected override Freezable CreateInstanceCore ()
		{
			throw new NotImplementedException ();
		}
	}

	[Test]
	public void Properties ()
	{
		ObjectAnimationBasePoker poker = new ObjectAnimationBasePoker ();
		Assert.AreEqual (typeof (object), poker.TargetPropertyType);
	}
}


}
