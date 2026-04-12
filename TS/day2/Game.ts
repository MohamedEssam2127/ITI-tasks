import { Card } from "./interfaces.js";
import { shuffleCards } from "./utils.js";

export class MemoryGame {
    private cards: Card[] = [];
    private gridContainer: HTMLElement | null;
    private flippedCards: number[] = [];
    private matchedCount: number = 0;
    private isLockBoard: boolean = false;
    private progressBar: HTMLElement | null;
    private flipSound = new Audio('./assets/audio/flip.mp3');
    private matchSound = new Audio('./assets/audio/good.mp3');
    private failSound = new Audio('./assets/audio/fail.mp3');
    private winSound = new Audio('./assets/audio/game-over.mp3');

    constructor(containerId: string) {
        this.gridContainer = document.getElementById(containerId);
        this.progressBar = document.getElementById('progressBar');
        this.init();
    }

    private init(): void {
        this.prepareCards();
        shuffleCards(this.cards);
        this.logCardGrid();
        this.render();
        this.updateProgress();
    }

    private logCardGrid(): void {
        const cols = 5;
        const rows = Math.ceil(this.cards.length / cols);
        let gridStr = '';
        for (let r = 0; r < rows; r++) {
            const rowCards: string[] = [];
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

    private prepareCards(): void {
        const tempCards: Card[] = [];
        for (let i = 1; i <= 10; i++) {
            const cardTemplate: Card = {
                id: i,
                imgSrc: `./assets/images/${i}.jpg`,
                isMatched: false,
                isFlipped: false
            };
            tempCards.push({ ...cardTemplate });
            tempCards.push({ ...cardTemplate });
        }
        this.cards = tempCards;
    }

    private render(): void {
        if (!this.gridContainer) return;
        this.gridContainer.innerHTML = '';

        this.cards.forEach((card, index) => {
            const cardElement = this.createCardElement(card, index);
            this.gridContainer?.appendChild(cardElement);
        });
    }

    private createCardElement(card: Card, index: number): HTMLElement {
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

    private handleFlip(cardElement: HTMLElement, index: number): void {
        if (this.isLockBoard) return;
        if (this.cards[index].isFlipped || this.cards[index].isMatched) return;
        
        this.flipSound.currentTime = 0;
        this.flipSound.play();
        
        cardElement.classList.add('flipped');
        this.cards[index].isFlipped = true;
        this.flippedCards.push(index);

        if (this.flippedCards.length === 2) {
            this.checkMatch();
        }
    }

    private checkMatch(): void {
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
        } else {
            this.failSound.currentTime = 0;
            this.failSound.play();

            setTimeout(() => {
                const firstEl = document.getElementById(`card-${firstIdx}`);
                const secondEl = document.getElementById(`card-${secondIdx}`);
                
                firstEl?.classList.remove('flipped');
                secondEl?.classList.remove('flipped');
                
                this.cards[firstIdx].isFlipped = false;
                this.cards[secondIdx].isFlipped = false;
                
                this.resetTurn();
            }, 1000);
        }
    }

    private updateProgress(): void {
        if (!this.progressBar) return;
        const percentage = (this.matchedCount / 10) * 100;
        this.progressBar.style.width = `${percentage}%`;
        this.progressBar.innerText = `${percentage}%`;
    }

    private resetTurn(): void {
        this.flippedCards = [];
        this.isLockBoard = false;
    }
}