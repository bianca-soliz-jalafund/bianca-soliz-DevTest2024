import Button from "../atoms/Button";
import FormField from "../molecules/formField";
import RadioGroup from "../molecules/radioGroup";


function VoteModal({ title, options, onClose, onVote }) {
  return(
    <div className="fixed inset-0 flex items-center justify-center bg-neutral-300 bg-opacity-75">
        <div className="bg-white p-6 rounded-lg shadow-lg max-w-sm w-full space-y-4">
            <div className="flex justify-between items-center">
                <h2 className="text-lg font-bold">{title}</h2>
                <button onClick={onClose} className="text-gray-500">CLOSE ✕</button>
            </div>
            <div>
                <FormField label="Email" placeholder="Enter your email" type="email" />
                <RadioGroup options={options} name="language" />
                <div className="flex justify-between">
                    <Button onClick={onClose}>Cancel</Button>
                    <Button onClick={onVote}>Vote</Button>
                </div>
            </div>
        </div>
    </div>
  );
};

export default VoteModal;
