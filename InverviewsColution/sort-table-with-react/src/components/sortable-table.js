import data from '../data.json';

const sortTableData = (array, { sortBy, direction }) => {
    return array.sort((a, b) => {
      if (a[sortBy] < b[sortBy]) return direction === 'ascending' ? -1 : 1
      if (a[sortBy] > b[sortBy]) return direction === 'ascending' ? 1 : -1
      return 0
    })
}

export const SortableTable = ({ sortConfig }) => {

    const shouldSort = sortConfig?.sortBy
    const tableData = shouldSort ? sortTableData(data, sortConfig) : data

    return (        
        <table>        
            <caption align="top">List of the users</caption>
            <thead>
                <tr>            
                    <th>Full Name</th>
                    <th>Email</th>
                    <th>Gender</th>
                    <th>Age</th>
                    <th>Start Date</th>
                </tr>
            </thead>
            <tbody>
                {tableData.map(person => (
                    <tr key={person.id}>
                    <td>{person.full_name}</td>
                    <td>{person.email}</td>
                    <td>{person.gender}</td>
                    <td>{person.age}</td>
                    <td>{person.start_dates}</td>
                    </tr>
                ))}
            </tbody>
        </table>
  );
};