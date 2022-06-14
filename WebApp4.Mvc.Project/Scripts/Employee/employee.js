
const fillDataTable = () => {
    $('#employee-list').DataTable({
        'ajax': {
            'url': 'Employee/List',
            'type': "GET",
            'dataType': 'json'
        },
        'columns': [
            { data: 'BusinessEntityID' },
            { data: 'NationalIDNumber' },
            { data: 'LoginID' },
            { data: 'OrganizationLevel' },
            { data: 'JobTitle' },
            { data: 'BirthDate' },
            { data: 'MaritalStatus' },
            { data: 'Gender' },
            { data: 'HireDate' },
            { data: 'SalariedFlag' },
            { data: 'VacationHours' },
            { data: 'SickLeaveHours' },
            { data: 'CurrentFlag' },
            { data: 'rowguid' },
            { data: 'ModifiedDate' },
            { data: 'ImagePath' }
        ]
    });
}

const employeeList = () => {
    $.ajax({
        url: "Employee/List",
        success: (result) => {
            return result
        }
    });
}

//$(document).ready(

//);



