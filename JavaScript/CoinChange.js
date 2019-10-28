function change(amount) {
    var currentamount = 0;
    if(typeof(amount)==="object"){
        amount.dollars>0? currentamount = amount.dollars *100: null;
        amount.quarters>0? currentamount += amount.quarters *25: null;
        amount.dimes>0? currentamount += amount.dimes *10: null;
        amount.nickels>0? currentamount += amount.nickels *5: null;
        amount.pennies>0? currentamount += amount.pennies *1: null;
    }
    else{
        currentamount = amount;
    }
    //Use dollars, quarters, dimes, nickels, and pennies.
    var values = [100, 25, 10, 5, 1];
    var denomination = ["dollars", "quarters", "dimes", "nickels", "pennies"]
    var _change = {
        "dollars": 0,
        "quarters": 0,
        "dimes": 0,
        "nickels": 0, 
        "pennies": 0
    };

    let quantity = 0;
    let reminder = 0;
    for (let i = 0; i < values.length; i++) {
        reminder = currentamount % values[i];
        quantity = (currentamount - reminder) / values[i];
        if(quantity>0){

            _change[denomination[i]] = quantity;
        }
        else{
            delete _change[denomination[i]];
        }
        currentamount = reminder;
    }
    return _change;
}


var mychange = change(343);
console.log(mychange);

var otherchange = { "dollars": 2, "dimes": 15,  "pennies": 5 };
mychange = change(otherchange);
console.log(mychange);