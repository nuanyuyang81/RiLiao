<template>
  <div class="block">
    <el-timeline>
      <el-timeline-item v-for="(item,index) of timeline" :key="index" :timestamp="item.timestamp" placement="top">
        <el-card>
          <h4>{{ item.title }}</h4>
          <p>{{ item.content }}</p>
        </el-card>
      </el-timeline-item>
    </el-timeline>
  </div>
</template>

<script>
export default {
  data () {
    return {
      timeline: [
        {
          timestamp: '2020/7/8',
          title: '更新食材采购信息',
          content: '更新食材采购信息'
        },
        {
          timestamp: '2020/7/8',
          title: '更新食材采购信息',
          content: '更新食材采购信息'
        },
        {
          timestamp: '2020/7/8',
          title: '更新食材采购信息',
          content: '更新食材采购信息'
        },
        {
          timestamp: '2020/7/8',
          title: '更新食材采购信息',
          content: '更新食材采购信息'
        }
      ]
    }
  }
}
</script>
