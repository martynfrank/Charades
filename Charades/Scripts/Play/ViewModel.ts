module play {
    export class ViewModel {
        currentPhrase: KnockoutObservable<PhraseDto>;
        constructor(item: PhraseDto) {
            this.currentPhrase = ko.observable<PhraseDto>(item);
        }
    }
}   