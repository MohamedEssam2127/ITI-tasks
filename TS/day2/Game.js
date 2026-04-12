import { shuffleCards } from "./utils.js";
export class MemoryGame {
    constructor(containerId) {
        this.cards = [];
        this.flippedCards = [];
        this.matchedCount = 0;
        this.isLockBoard = false;
        this.flipSound = new Audio('./assets/audio/flip.mp3');
        this.matchSound = new Audio('./assets/audio/good.mp3');
        this.failSound = new Audio('./assets/audio/fail.mp3');
        this.winSound = new Audio('./assets/audio/game-over.mp3');
        this.gridContainer = document.getElementById(containerId);
        this.progressBar = document.getElementById('progressBar');
        this.init();
    }
    init() {
        this.prepareCards();
        shuffleCards(this.cards);
        this.logCardGrid();
        this.render();
        this.updateProgress();
    }
    logCardGrid() {
        const cols = 5;
        const rows = Math.ceil(this.cards.length / cols);
        let gridStr = '';
        for (let r = 0; r < rows; r++) {
            const rowCards = [];
            for (let c = 0; c < cols; c++) {
                const idx = r * cols + c;
                if (idx < this.cards.length) {
                    const id = this.cards[idx].id.toString().padStart(2, ' ');
                    rowCards.push(`[${id}]`);
                }
            }
            const rowLabel = `Row ${r + 1}: `;
            gridStr += rowLabel + rowCards.join('  ') + '\n';
        }
        console.log(gridStr);
    }
    prepareCards() {
        const tempCards = [];
        for (let i = 1; i <= 10; i++) {
            const cardTemplate = {
                id: i,
                imgSrc: `./assets/images/${i}.jpg`,
                isMatched: false,
                isFlipped: false
            };
            tempCards.push(Object.assign({}, cardTemplate));
            tempCards.push(Object.assign({}, cardTemplate));
        }
        this.cards = tempCards;
    }
    render() {
        if (!this.gridContainer)
            return;
        this.gridContainer.innerHTML = '';
        this.cards.forEach((card, index) => {
            var _a;
            const cardElement = this.createCardElement(card, index);
            (_a = this.gridContainer) === null || _a === void 0 ? void 0 : _a.appendChild(cardElement);
        });
    }
    createCardElement(card, index) {
        const cardElement = document.createElement('div');
        cardElement.classList.add('card');
        cardElement.id = `card-${index}`;
        cardElement.innerHTML = `
            <div class="card-inner">
                <div class="card-front"></div>
                <div class="card-back">
                    <img src="${card.imgSrc}" alt="card">
                </div>
            </div>
        `;
        cardElement.addEventListener('click', () => this.handleFlip(cardElement, index));
        return cardElement;
    }
    handleFlip(cardElement, index) {
        if (this.isLockBoard)
            return;
        if (this.cards[index].isFlipped || this.cards[index].isMatched)
            return;
        this.flipSound.currentTime = 0;
        this.flipSound.play();
        cardElement.classList.add('flipped');
        this.cards[index].isFlipped = true;
        this.flippedCards.push(index);
        if (this.flippedCards.length === 2) {
            this.checkMatch();
        }
    }
    checkMatch() {
        this.isLockBoard = true;
        const [firstIdx, secondIdx] = this.flippedCards;
        if (this.cards[firstIdx].id === this.cards[secondIdx].id) {
            this.cards[firstIdx].isMatched = true;
            this.cards[secondIdx].isMatched = true;
            this.matchedCount++;
            this.matchSound.currentTime = 0;
            this.matchSound.play();
            this.updateProgress();
            if (this.matchedCount === 10) {
                setTimeout(() => {
                    this.winSound.currentTime = 0;
                    this.winSound.play();
                }, 500);
            }
            this.resetTurn();
        }
        else {
            this.failSound.currentTime = 0;
            this.failSound.play();
            setTimeout(() => {
                const firstEl = document.getElementById(`card-${firstIdx}`);
                const secondEl = document.getElementById(`card-${secondIdx}`);
                firstEl === null || firstEl === void 0 ? void 0 : firstEl.classList.remove('flipped');
                secondEl === null || secondEl === void 0 ? void 0 : secondEl.classList.remove('flipped');
                this.cards[firstIdx].isFlipped = false;
                this.cards[secondIdx].isFlipped = false;
                this.resetTurn();
            }, 1000);
        }
    }
    updateProgress() {
        if (!this.progressBar)
            return;
        const percentage = (this.matchedCount / 10) * 100;
        this.progressBar.style.width = `${percentage}%`;
        this.progressBar.innerText = `${percentage}%`;
    }
    resetTurn() {
        this.flippedCards = [];
        this.isLockBoard = false;
    }
}
//# sourceMappingURL=Game.js.map