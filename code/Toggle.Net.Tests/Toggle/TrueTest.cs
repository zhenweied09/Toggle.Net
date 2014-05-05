﻿using NUnit.Framework;
using SharpTestsEx;
using Toggle.Net.Configuration;
using Toggle.Net.Internal;
using Toggle.Net.Providers.InMemory;
using Toggle.Net.Specifications;

namespace Toggle.Net.Tests.Toggle
{
	public class TrueTest
	{
		[Test]
		public void ShouldBeEnabled()
		{
			const string flag = "someFlag";

			var toggle = new ToggleConfiguration(new InMemoryProviderFactory(
				new Feature(flag, new TrueSpecification())
			)).Create();

			toggle.IsEnabled(flag)
				.Should().Be.True();
		}
	}
}