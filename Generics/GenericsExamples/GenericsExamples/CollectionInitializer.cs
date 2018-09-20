using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    public class CollectionInitializer<T> where T: class
    {
        private T[] collection;

        public CollectionInitializer(int collectionLength)
        {
            collection = new T[collectionLength];
        }

        public void AddElementsToCollection(params T[]elements)
        {
            for(int i=0; i<elements.Length; i++)
            {
                collection[i] = elements[i];
            }
        }

        public T[] RetrieveAllElements()
        {
            return collection;
        }

        public T RetreiveElementOnIndex(int index)
        {
            return collection[index];
        }
    }
}
