function Input ({ placeholder, type = "text", ...props }){
  return(
    <input
        type={type}
        placeholder={placeholder}
        className="border-neutral-200 focus:border-teal-500 rounded px-3 py-2 w-full mb-4"
        {...props}
    />
  );
};

export default Input;