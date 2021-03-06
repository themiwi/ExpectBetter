using System.Collections.Generic;

namespace ExpectBetter.Matchers
{
    /// <summary>
    /// Exposes test methods on values implementing
    /// <see cref="ICollection&lt;T&gt;"/>.
    /// </summary>
    /// <typeparam name="T">
    /// The type of element contained in the collection being tested.
    /// </typeparam>
    public class CollectionMatcher<T> : BaseCollectionMatcher<ICollection<T>, T, CollectionMatcher<T>>
    {
    }
}
