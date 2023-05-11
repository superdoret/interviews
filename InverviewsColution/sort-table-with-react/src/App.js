import React from 'react'
import {SortableTable} from './components/sortable-table';
import './App.css';

function App() {

  const [sortConfig, setSortConfig] = React.useState({ sortBy: 'full_name', direction: 'ascending' })

  const handleSortByChange = (e) => {
    e.preventDefault();    
    setSortConfig({ sortBy: e.target.value, direction: sortConfig.direction });  
  }
  
  const handleDirection = (e, direction) => {
    e.preventDefault();    
    setSortConfig({ sortBy: sortConfig.sortBy, direction: direction });  
  }  

  return (
    <div className="App">
      <h1>Sortable Table</h1>      
        <input type="text" id="sortBy" name="sortBy" onChange={(e) =>handleSortByChange(e)}></input>
        <button onClick={(e) => handleDirection(e, 'ascending')}>Ascending</button>
        <button onClick={(e) => handleDirection(e, 'descending')}>Descending</button>          
        <SortableTable sortConfig={sortConfig} />
    </div>
  );
}

export default App;
