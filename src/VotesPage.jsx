import { useState } from "react";
import VoteModal from "./components/organisms/VoteModal";
import Button from "./components/atoms/Button";

function VotePage() {
    const [isModalOpen, setModalOpen] = useState(false);

    const handleVote = () => {
        console.log("Vote submitted!");
        setModalOpen(false);
    };

    return (
        <div className="flex flex-col p-4">
            <Button onClick={() => setModalOpen(true)} className="bg-red-500 text-black px-4 py-2 rounded">
                Open Vote Modal
            </Button>
            {isModalOpen && (
                <VoteModal
                    title="What is your favorite Programming Language?"
                    options={["C#", "JavaScript", "Python"]}
                    onClose={() => setModalOpen(false)}
                    onVote={handleVote}
                />
            )}
        </div>
    );
}

export default VotePage;
