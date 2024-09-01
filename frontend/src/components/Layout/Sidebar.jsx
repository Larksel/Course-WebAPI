import React from 'react';

const Sidebar = () => {
  return (
    <div className='fixed flex-col w-[250px] h-full border-r-[1px] border-[#bd1a37]'>
      <div className='flex flex-col text-lg text-[#bd1a37]'>
        <button className='h-12 hover:bg-[#dd637a] hover:text-white border-b-2 border-solid border-[#e2b7bf]'>Página Inicial</button>
        <button className='h-12 hover:bg-[#dd637a] hover:text-white border-b-2 border-solid border-[#e2b7bf]'>Meu Restaurante</button>
      </div>
    </div>
  );
}

export default Sidebar;