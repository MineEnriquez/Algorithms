var person = {
    firstName: "John",
    lastName: "Doe",
    id: 5566
};

function PrintKeys() {
    console.log("-------Print Keys Function--------------")
    for (var key in person) {
        console.log(key);
    };
}

function PrintValues() {
    console.log("-------Print Vaues Function--------------")
    for (var key in person) {
        console.log(person[key]);
    }
}

function zip(arr1, arr2) {
    console.log("-------Zip Function-------->>>")
    var newobject = {};

    for (var i = 0; i < arr1.length; i++) {
        newobject[arr1[i]] = arr2[i];
    };

    for (var key in newobject) {
        console.log(key);
    }

    for (var key in newobject) {
        console.log(newobject[key]);
    }
    console.log("<<<-------Zip Function--------")
    return newobject;
}

zip(["name", "nicknme"], ["Minerva", "Minnie"]);
