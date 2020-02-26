Snowball.exe: Snowball.cs Fighter.dll RoboFighter.dll
	mcs Snowball.cs /reference:Fighter.dll /reference:RoboFighter.dll

RoboFighter.dll: RoboFighter.cs Fighter.dll
	mcs RoboFighter.cs /target:library /reference:Fighter.dll

Fighter.dll: Fighter.cs
	mcs Fighter.cs /target:library

clean:
	rm *.dll
	rm *.exe

run: Snowball.exe
	mono Snowball.exe

