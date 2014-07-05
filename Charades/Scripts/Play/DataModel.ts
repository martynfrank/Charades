module play {
    export class Urls {
        static getRandomPhrase: string;
    }
    export class PhraseDto {
        Name: string;
        Year: number;
        Type: Type;
    }
    export enum Type {
        Movie,
        Song
    }
    export class DataContext {
        static getRandomPhrase(callback: (data: PhraseDto) => void) {
            this.ajax(Urls.getRandomPhrase, {  }, callback);
        }
        private static ajax(url: string, data: any, success?: (data: any) => void, block: boolean = true) {
            $.ajax({
                type: 'POST',
                url: url,
                contentType: 'application/json',
                data: ko.toJSON(data),  
                global: block,
                success: response => {
                    if (success && (!response || !response.redirectLocation)) {
                        success(response);
                    }
                }
            });
        }
    }
}