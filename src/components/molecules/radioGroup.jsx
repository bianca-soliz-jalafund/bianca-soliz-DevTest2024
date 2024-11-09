import RadioOption from "../atoms/RadioOption.jsx";

function RadioGroup({ options, name }) {
  return(
    <div className="space-y-2">
        {options.map((option) => (
            <RadioOption key={option} label={option} value={option} name={name} />
        ))}
    </div>
  );
};

export default RadioGroup;
