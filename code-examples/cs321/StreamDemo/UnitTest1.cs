using System.Collections;
using System.Diagnostics.Contracts;

namespace StreamDemo
{
    public class StreamEnumerable : IEnumerable<string>
    {
        public StreamReader Reader { get; }
        public StreamEnumerable(StreamReader reader)
        {
            Reader = reader;
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class StreamEnumerator : IEnumerator<string> 
    {
        public StreamEnumerator(StreamReader reader)
            => Reader = reader;

        public StreamReader Reader { get; }

        public string Current { get; private set; }

        object IEnumerator.Current 
            => Current;

        public bool MoveNext()
            => (Current = Reader.ReadLine()) != null;

        public void Reset()
            => throw new NotImplementedException();

        public void Dispose() 
            => Reader.Dispose();
    }

    public class Demo
    {
        public static IEnumerable<string> GetAllTextFromStandardInput_v1() 
        { 
            var list = new List<string>(); 
            var line = Console.ReadLine(); 
            while (line != null) 
            { 
                list.Add(line); 
                line = Console.ReadLine(); 
            } 
            return list; 
        }


        public static IEnumerable<string> GetAllTextFromStandardInput() 
        { 
            var line = Console.ReadLine(); 
            while (line != null) 
            { 
                yield return line; 
            } 
        }

    }
}