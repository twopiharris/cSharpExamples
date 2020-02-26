CritViewer.exe: CritViewer.cs Critter.dll
	mcs CritViewer.cs /reference:Critter.dll

Critter.dll: Critter.cs
	mcs /target:library Critter.cs

clean:
	rm *.dll
	rm *.exe

run: CritViewer.exe
	mono CritViewer.exe

