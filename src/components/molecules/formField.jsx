import Input from "../atoms/Input";


function FormField ({ label, placeholder, type }) {
  return(

    <div>
        <label className="text-sm font-semibold">{label}</label>
        <Input type={type} placeholder={placeholder} />
    </div>
  );
};

export default FormField;

