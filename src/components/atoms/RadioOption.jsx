function RadioOption({ label, value, name }) {
  return(
    <label className="flex items-center space-x-2">
        <input type="radio" name={name} value={value} className="form-radio" />
        <span>{label}</span>
    </label>
  );
};

export default RadioOption;