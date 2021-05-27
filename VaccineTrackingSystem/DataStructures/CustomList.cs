using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineTrackingSystem.DataStructures
{
	class CustomList<T> : IEnumerable<T>
	{
		T []arr;
		int size;
		public int CurrentPos;
		public T this[int index]
		{
			get { return (T)arr[index]; }
		}
		public CustomList()
		{
			arr = new T[105];
			size = 106;
			CurrentPos = 0;
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
			for (int i = pos; i < CurrentPos - 1; i++)
				arr[i] = arr[i + 1];
			CurrentPos--;
		}
		public void Clear()
		{
			for (int i = 0; i < CurrentPos; i++)
				arr[i] = default(T);
		}
		public void Remove(T obj )
		{
			int idx = 0;
			for (int i = 0; i < CurrentPos - 1; i++)
			{
				if (arr[i].Equals(obj))
					idx = i;
			}

			for (int i = idx; i < CurrentPos; i++)
				arr[i] = arr[i + 1]; 

		}
		public IEnumerator<T> GetEnumerator()
		{
			foreach (T o in arr)
			{
				if (o == null)
				{
					break;
				}
				yield return o;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}


	}
}