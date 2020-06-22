function printStudents(arr){
    for(var i=0; i< arr.length; i++){
        console.log('Name:', arr[i].name + ',', 'Cohort:', arr[i].cohort );
    }
}
let students = [
    {name: 'Remy', cohort: 'Jan'},
    {name: 'Chuck', cohort: 'Sep'}
]

printStudents(students);