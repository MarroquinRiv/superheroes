using superheroes.clases;

superman superM = new superman();

superM.fuerza = 150;
superM.Nombre = "Clark Kent";
superM.agilidad = 100;

//superM.presentarse();
//superM.salvarElMundo();
//superM.volar();
//Console.WriteLine("Superman tinene una fuerza de {0}", superM.fuerza);
//Console.WriteLine("Superman se llama {0}", superM.Nombre);

superheroeDB superh = new superheroeDB();
//superh.crearTablaHeroe();
superh.insertarHeroe(superM);