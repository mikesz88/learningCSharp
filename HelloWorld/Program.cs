namespace HelloWorld
{
    internal class ClientActivity
    {

        public static void Main(string[] args)
        {
            // define variables
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            // 2. String formatting.
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I'm a {2}.", name, age, job);

            // 3. String interpolation.
            // string interpolation uses $ at the start which will allow us to write our
            // variables like this {variableName}
            Console.WriteLine($"Hello \n my name is {name}, I am {age} years old.");

            // Verbatim strings
            // verbatim strings start with @ and tells the compiler to take the string literally
            // and ignore any spaces and escape characterslike \n
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit. Elementum integer enim neque volutpat ac tincidunt vitae semper quis. Malesuada fames ac turpis egestas integer. Lectus urna duis convallis convallis. Orci sagittis eu volutpat odio facilisis mauris sit amet massa. Feugiat in fermentum posuere urna nec tincidunt praesent semper feugiat. Ac turpis egestas maecenas pharetra convallis posuere morbi leo. Volutpat maecenas volutpat blandit aliquam etiam erat velit scelerisque. Est placerat in egestas erat. Posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Dictum fusce ut placerat orci nulla pellentesque dignissim. Lectus urna duis convallis convallis tellus id. Venenatis tellus in metus vulputate eu. Faucibus et molestie ac feugiat sed lectus vestibulum. Mauris pharetra et ultrices neque ornare aenean euismod elementum nisi. Turpis tincidunt id aliquet risus feugiat in. Dolor sed viverra ipsum nunc aliquet bibendum enim facilisis gravida. Pellentesque habitant morbi tristique senectus et netus.

Viverra adipiscing at in tellus integer. Tristique et egestas quis ipsum. In hac habitasse platea dictumst. Auctor neque vitae tempus quam. Volutpat odio facilisis mauris sit amet massa vitae. Blandit libero volutpat sed cras ornare. Scelerisque in dictum non consectetur a erat nam at lectus. Venenatis a condimentum vitae sapien pellentesque habitant morbi tristique. Vulputate dignissim suspendisse in est. Tortor at risus viverra adipiscing at. At risus viverra adipiscing at in tellus integer feugiat scelerisque. Cras fermentum odio eu feugiat pretium nibh. Et malesuada fames ac turpis egestas integer eget. Ornare arcu odio ut sem nulla pharetra diam sit amet. Maecenas sed enim ut sem viverra.

Scelerisque viverra mauris in aliquam. Scelerisque felis imperdiet proin fermentum leo vel orci. Eget nunc lobortis mattis aliquam faucibus. Ridiculus mus mauris vitae ultricies leo integer. Sed cras ornare arcu dui vivamus arcu felis bibendum. Sed velit dignissim sodales ut. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt. Sagittis purus sit amet volutpat consequat mauris nunc congue. Amet facilisis magna etiam tempor. Quis vel eros donec ac odio tempor. Posuere sollicitudin aliquam ultrices sagittis orci a scelerisque purus semper. At imperdiet dui accumsan sit amet nulla facilisi morbi. Fames ac turpis egestas integer eget aliquet nibh praesent. Nunc congue nisi vitae suscipit. Urna id volutpat lacus laoreet non curabitur gravida arcu. Tellus in hac habitasse platea dictumst vestibulum rhoncus est pellentesque.

Neque vitae tempus quam pellentesque nec nam aliquam. Sed arcu non odio euismod. Egestas egestas fringilla phasellus faucibus scelerisque. Vitae congue mauris rhoncus aenean vel elit scelerisque. Facilisi morbi tempus iaculis urna id volutpat lacus laoreet. Nunc mi ipsum faucibus vitae aliquet nec. Condimentum id venenatis a condimentum vitae sapien pellentesque habitant morbi. A diam maecenas sed enim ut sem viverra aliquet. Euismod in pellentesque massa placerat duis ultricies lacus sed turpis. Arcu dui vivamus arcu felis bibendum ut tristique.

Aliquet porttitor lacus luctus accumsan. Malesuada pellentesque elit eget gravida cum. Quam pellentesque nec nam aliquam sem et tortor consequat id. Dis parturient montes nascetur ridiculus mus. Tellus integer feugiat scelerisque varius morbi. Purus gravida quis blandit turpis cursus in hac habitasse platea. Aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat. Nullam ac tortor vitae purus faucibus. Sem integer vitae justo eget magna fermentum iaculis eu. Arcu ac tortor dignissim convallis aenean. Habitant morbi tristique senectus et. Blandit aliquam etiam erat velit scelerisque in.");

            // instead of using \\ to write file paths we can use verbatim strings to make it easier
            // if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            // with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muahaha \n you have no powers here!.");
            Console.WriteLine("Muahaha \n you have no powers here!.");
        }
    }
}