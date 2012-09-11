using System;
using System.Collections.Generic;
using NUnit.Framework;

using ExpectBetter;
using ExpectBetter.Matchers;

namespace SharpTests
{
	[TestFixture]
	public class ObjectMatcherTests
	{
		[Test]
		public void ToBeNull_WhenActualIsNull_ReturnsTrue()
		{
			var result = Expect.The(null as object).ToBeNull();
			Assert.IsTrue(result);
		}

		[Test, ExpectedException(typeof(ExpectationException))]
		public void ToBeNull_WhenActualIsNotNull_Throws()
		{
			Expect.The(new object()).ToBeNull();
		}

		[Test, ExpectedException(typeof(ExpectationException))]
		public void Not_ToBeNull_WhenActualIsNull_Throws()
		{
			Expect.The(null as object).Not.ToBeNull();
		}

		[Test]
		public void Not_ToBeNull_WhenActualIsNotNull_ReturnsTrue()
		{
			var result = Expect.The(new object()).Not.ToBeNull();
			Assert.IsTrue(result);
		}

		[Test]
		public void ToBeTheSameAs_WhenActualReferenceEqualsExpected_ReturnsTrue()
		{
			var actual = new object();
			var expected = actual;
			var result = Expect.The(actual).ToBeTheSameAs(expected);

			Assert.IsTrue(result);
		}

		[Test, ExpectedException(typeof(ExpectationException))]
		public void ToBeTheSameAs_WhenActualDiffersFromExpected_Throws()
		{
			Expect.The(new object()).ToBeTheSameAs(new TypeLoadException());
		}

		[Test]
		public void ToBeAnInstanceOf_WhenActualHasExpectedType_ReturnsTrue()
		{
			var actual = new Dictionary<string, string>();
			var result = Expect.The((object)actual).ToBeAnInstanceOf<IDictionary<string, string>>();

			Assert.IsTrue(result);
		}
	}
}
