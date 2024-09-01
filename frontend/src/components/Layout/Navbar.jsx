import React from 'react';
// import Logo from '../../assets/logoIcon.png';

const Navbar = () => {
  return (
    <div className='flex w-full bg-[#bd1a37] sm:h-[64px] h-[56px] px-4 items-center drop-shadow-m'>
      {/* <Logo /> */}
      <div className='flex w-full justify-end'>
        <div className='bg-blue-400 rounded-full w-8 h-8'>
          {/* Avatar */}
        </div>
      </div>
    </div>
  )
}

export default Navbar;