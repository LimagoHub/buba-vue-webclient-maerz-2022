<template>
    <h1>{{ myForm.headline }}</h1>


    <div v-if="myForm.errorMessage">
        {{myForm.errorMessage}}
    </div>
    <div v-else>
        <form @submit.prevent="submitForm">

            <select name="useCaseConfig" id="useCaseConfig" v-model="myResult.useCaseConfig">
                <option v-for="useCase of myForm.useCaseConfigs" v-bind:key="useCase.value" v-bind:value="useCase.key">{{useCase.value}}</option>
            </select>

            <input class="form-control datepicker" type="date" v-model="myResult.betrachtungstag" />
            <h6>{{ myForm.logHint }}</h6>
            <button type="submit">Senden</button>
        </form>
    </div>
    

    <h6>{{ myForm.logHint }}</h6>

</template>
<script>
    import axios from 'axios'

    

    export default {
        name: "JobDashboard",
        
        data() {
            return {
                myForm: {
                    "betrachtungstag": "",
                    "headline": "Dummy",
                    "logHint": "Dummy",
                    "errorMessage": null,
                    "useCaseConfigs": []
                },
                myResult: {
                    "useCaseConfig": "1234",
                    "betrachtungstag": "2022-03-25T10:12:03.0664481+01:00"
                }
            };
        },
       
        methods: {
            getMyForm() {
                axios.get('/forms/job-dashboard')
                    .then((response) => {
                        this.myForm = response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            },
            submitForm() {

                axios.post('/jobdashboard', this.myResult)
                    .then(() => {

                        alert("ok");
                    })
                    .catch((error) => {
                        alert(error);
                   })
                   .finally(() => {
                        /* ok */
                  });
            }

        },
        mounted() {
            this.getMyForm();
        }
    }
</script>
