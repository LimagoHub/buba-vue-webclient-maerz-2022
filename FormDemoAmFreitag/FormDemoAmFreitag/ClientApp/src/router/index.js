import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import JobDashboard from "@/components/JobDashboard.vue";

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/JobDashboard",
        name: "JobDashboard",
        component: JobDashboard,
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;