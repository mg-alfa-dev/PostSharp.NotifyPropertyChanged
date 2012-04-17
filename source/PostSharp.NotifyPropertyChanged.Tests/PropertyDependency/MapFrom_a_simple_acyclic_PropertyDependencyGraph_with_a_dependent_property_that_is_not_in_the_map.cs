﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace PostSharp.NotifyPropertyChanged.Tests
{
    public static partial class PropertyDependency_Tests
    {
        [Test]
        public static void MapFrom_a_simple_acyclic_PropertyDependencyGraph_with_a_dependent_property_that_is_not_in_the_map()
        {
            var simpleAcyclicGraph =
                new Dictionary<string, HashSet<string>>
                    {
                        {"parent", new HashSet<string> {"child"}},
                    };

            var actualMap = PropertyDependency.MapFrom(simpleAcyclicGraph);

            "should successfuly return the mapping to the dependent property"
                .AssertThat(actualMap["parent"].ToArray(), Is.EquivalentTo(new[] { "child" }));
        }
    }
}