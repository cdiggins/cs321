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

        public string Line { get; private set; }

        public StreamReader Reader { get; }

        public string Current 
            => throw new NotImplementedException();

        object IEnumerator.Current 
            => throw new NotImplementedException();

        public bool MoveNext()
            => (Line = Reader.ReadLine()) != null;

        public void Reset()
            => throw new NotImplementedException();

        public void Dispose() 
            => Reader.Dispose();
    }
}