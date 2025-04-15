using System.Collections;
//Your code here (above the PersonName class)

var rock = new PersonName("Dwayne", "Johnson", "Rock");

Console.WriteLine(rock.Skip(1).First());

public class PersonName : IEnumerable<string>
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }

    public PersonName(string firstName, string lastName, string middleName = null)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<string> GetEnumerator()
    {
        yield return FirstName;

        if (MiddleName != null)
            yield return MiddleName;

        yield return LastName;

    }

    /*public class NameEnumerator : IEnumerator<string>
    {
        private readonly PersonName _person;
        private int _currentIndex = -1;
        public NameEnumerator(PersonName person) => _person = person;
        public bool MoveNext()
        {
            _currentIndex++;
            return _person.MiddleName != null && _currentIndex < 3 || _person.MiddleName == null && _currentIndex < 2;
        }
        public void Reset() => _currentIndex = -1;
        public string Current
        {
            get 
            {
                if (_currentIndex == 0) return _person.FirstName;
                if (_currentIndex == 1 && _person.MiddleName != null) return _person.MiddleName;
                return _person.LastName;
            }
        }
        object IEnumerator.Current => Current;
        public void Dispose() { }
    }*/
}