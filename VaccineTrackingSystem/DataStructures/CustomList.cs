using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineTrackingSystem.DataModels;

namespace VaccineTrackingSystem.DataStructures
{
	class CustomList<T> : IEnumerable<T>, IEnumerator
	{
		T []arr;
		int size;
		public int CurrentPos = -1;
		public int position = -1;
        private bool disposedValue;

        public T this[int index]
		{
			get { return (T)arr[index]; }
		}
		public CustomList()
		{
			arr = new T[105];
			size = 105;
		}

		public bool MoveNext()
		{
			position++;
			return (position <= CurrentPos);
		}
		public void Reset()
		{
			position = 0;
		}
		public object Current
		{
			get { return arr[position]; }
		}


        public void Expand()
		{
			int NewSize = size + 60;
			T[] NewArr = new T[NewSize];
			for (int i = 0; i < size; i++)
				NewArr[i] = arr[i];
				
			arr = NewArr;
			size = NewSize;
		}
		public void Add( T value)
		{
			CurrentPos++;
			if(CurrentPos == size)
			{
				Expand();
			}
			arr[CurrentPos] = value;
		}

		public void Delete(int pos)
		{
			if (pos > CurrentPos || pos < 0) return;
			for (int i = pos; i < CurrentPos; i++)
				arr[i] = arr[i + 1];
			arr[CurrentPos] = default(T);
			CurrentPos--;
		}
		public void Clear()
		{
			for (int i = 0; i <= CurrentPos; i++)
				arr[i] = default(T);
			CurrentPos = -1;
		}
		public void Remove(T obj)
		{
			int idx = -1;
			for (int i = 0; i <= CurrentPos; i++)
				if (Object.ReferenceEquals(arr[i],obj))
					idx = i;
			if (idx == -1) return;
			Delete(idx);

		}
		public IEnumerator<T> GetEnumerator()
		{
			foreach (T o in arr)
			{
				if (o == null)
					break;
				yield return o;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

        
    }
}