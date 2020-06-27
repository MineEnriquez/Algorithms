var tigger = {character: "Tigger"};
var pooh = {character: "Winnie the pooh"};
var piglet =  {character: "Pigglet"};
var bees = {character: "Bees"};
var owl = {character: "Owl"};
var chris = {character: "Christopher Robin"};
var rabit = {character: "Rabbit"};
var gopher = {character: "Gopher"};
var roo = {character: "Kanga roo"};
var eeyore = {character: "Eeyore"};
var heffa = {character: "Heffalymps"};

tigger.north = pooh;
pooh.south = tigger;
pooh.west = piglet;
pooh.east = bees;
pooh.north = chris;
piglet.north = owl;
piglet.east = pooh;
chris.west = owl;
chris.south = pooh;
chris.east = rabit;
chris.north = roo;
rabit.west = chris;
rabit.south = bees;
gopher.west = rabit;
roo.south = chris;
roo.north = eeyore;
eeyore.south = roo;
eeyore.east = heffa;
heffa.west = eeyore;

var player = {
    location : tigger
}

