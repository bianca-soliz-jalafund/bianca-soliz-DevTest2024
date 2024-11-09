function Button({ children, onClick }) 
{
  return(
    <button onClick={onClick} className="bg-neutral-100 text-black px-4 py-2 rounded hover:bg-neutral-300">
      {children}
    </button>
  );
};

export default Button;
