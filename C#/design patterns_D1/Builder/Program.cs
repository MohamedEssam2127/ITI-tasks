namespace Builder
{
    
        public class Playground
        {
            private List<string> _parts = new List<string>();

            public void Add(string part)
            {
                _parts.Add(part);
            }

            public void Display()
            {
                Console.WriteLine("Playground Parts:");
                foreach (string part in _parts)
                {
                    Console.WriteLine($"-> {part}");
                }
            }
        }

        public interface IBuilder
        {
            void BuildGallery();
            void BuildSurface();
            void BuildAudience();
            Playground GetGround();
        }

        public class ItalyGroundBuilder : IBuilder
        {
            private Playground _playground = new Playground();

            public void BuildGallery()
            {
                _playground.Add("Roman Style Gallery");
            }

            public void BuildSurface()
            {
                _playground.Add("Natural Grass Surface");
            }

            public void BuildAudience()
            {
                _playground.Add("Passionate Italian Fans");
            }

            public Playground GetGround()
            {
                return _playground;
            }
        }

        public class EnglandGroundBuilder : IBuilder
        {
            private Playground _playground = new Playground();

            public void BuildGallery()
            {
                _playground.Add("Modern Closed Gallery");
            }

            public void BuildSurface()
            {
                _playground.Add("Hybrid Grass Surface");
            }

            public void BuildAudience()
            {
                _playground.Add("Formal English Crowd");
            }

            public Playground GetGround()
            {
                return _playground;
            }
        }

        public class Director
        {
            public void ConstructGround(IBuilder builder)
            {
                builder.BuildGallery();
                builder.BuildSurface();
                builder.BuildAudience();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Director director = new Director();

                Console.WriteLine(" Italy Ground:");
                IBuilder Builder = new ItalyGroundBuilder();
              

                director.ConstructGround(Builder);

                Playground italyGround = Builder.GetGround();
                italyGround.Display();

                Console.WriteLine("\n England Ground:");
                 Builder = new EnglandGroundBuilder();
                director.ConstructGround(Builder);
                Playground englandGround = Builder.GetGround();
                englandGround.Display();
            }
        }
    }

