CritViewer.exe: CritViewer.cs GlitterCritter.dll Critter.dll
	mcs CritViewer.cs /reference:GlitterCritter.dll /reference:Critter.dll

GlitterCritter.dll: GlitterCritter.cs Critter.dll
	mcs GlitterCritter.cs /target:library /reference:Critter.dll

Critter.dll: Critter.cs
	mcs Critter.cs /target:library

clean:
	rm *.dll
	rm *.exe

run: CritViewer.exe
	mono CritViewer.exe

