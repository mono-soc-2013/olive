
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
public class CharAnimationBaseTest
{
	class CharAnimationBasePoker : CharAnimationBase
	{
		protected override char GetCurrentValueCore (char defaultOriginValue, char defaultDestinationValue,
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
		CharAnimationBasePoker poker = new CharAnimationBasePoker ();
		Assert.AreEqual (typeof (char), poker.TargetPropertyType);
	}
}


}
