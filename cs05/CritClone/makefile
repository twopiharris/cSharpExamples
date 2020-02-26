CritViewer: CritViewer.cs Critter.dll Clone.dll
	mcs CritViewer.cs /reference:Critter.dll /reference:Clone.dll

Clone.dll: Clone.cs Critter.dll
	mcs Clone.cs /target:library /reference:Critter.dll

Critter.dll: Critter.cs
	mcs Critter.cs /target:library

clean:
	rm *.dll
	rm *.exe

run: CritViewer
	mono CritViewer.exe


