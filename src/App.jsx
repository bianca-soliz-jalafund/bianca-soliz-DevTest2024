import {Routes, Route} from 'react-router-dom'
import VotePage from './VotesPage'

function App() {
  return (
    <div className='flex flex-col min-h-screen w-full'>      
      <Routes>
        <Route path='*' element={<VotePage />}/>
      </Routes>
    </div>
  );
};

export default App